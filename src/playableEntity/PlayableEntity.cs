namespace roguegame;

using Godot;
using System;

public partial class PlayableEntity : Entity {

  private InputManager? _inputManager;
  public override void _Ready() {
    _inputManager = GetNode<InputManager>("InputManager");
    if (_inputManager == null) {
      throw new InvalidOperationException("InputManager node not found in entity.");
    }
  }
  public override void _Process(double delta) {
    if (_inputManager == null) {
      return;
    }
    _inputManager.Process(delta);
  }

  public override void _PhysicsProcess(double delta) {
    if (_inputManager == null || _inputManager.GetNormalized() == new Vector2(0, 0)) {
      return;
    }
    Velocity = Velocity.MoveToward(_speed * _inputManager.GetNormalized(), (float)(_acceleration * delta));
    MoveAndSlide();
  }
}