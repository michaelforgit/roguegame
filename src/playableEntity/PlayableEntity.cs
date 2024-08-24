namespace roguegame;

using Godot;
using System;
using System.Collections.Generic;

public partial class PlayableEntity : Entity {

  private InputManager? _inputManager;
  private List<DefaultWeapon> _weapons = new List<DefaultWeapon>();  //Need to add weapons to list when grabbing them.

  private double _timer;
  public override void _Ready() {
    _inputManager = GetNode<InputManager>("InputManager");
    if (_inputManager == null) {
      throw new InvalidOperationException("InputManager node not found in entity.");
    }
    // Add weapons in that are on the character.
    foreach (var child in GetChildren()) {
      var childName = child.Name.ToString();
      if (childName.EndsWith("Weapon")) {
        if (child is DefaultWeapon castedWeapon) {
          _weapons.Add(castedWeapon);
          GD.Print($"Found a Weapon node: {childName}");
        }
      }
    }
  }
  public override void _Process(double delta) {
    _timer += delta;
    if (_inputManager == null) {
      return;
    }
    _inputManager.Process(delta);
    if (_timer >= 3) {
      foreach (var weapon in _weapons) {
        weapon.Attack(GlobalPosition, _inputManager.Raw);
      }
      _timer = 0;
    }
  }

  public override void _PhysicsProcess(double delta) {
    if (_inputManager == null || _inputManager.Normalized == new Vector2(0, 0)) {
      return;
    }
    Velocity = Velocity.MoveToward(_speed * _inputManager.Normalized, (float)(_acceleration * delta));
    MoveAndSlide();
  }
}
