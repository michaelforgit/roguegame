namespace roguegame;

using Godot;
using System;
[GlobalClass]
public partial class DefaultWeapon : Node2D {
  private PackedScene _bulletScene = GD.Load<PackedScene>("res://src/bullet/Bullet.tscn");
  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta) {
    // Attack(new Vector2(0, 0), new Vector2(0, 0));
  }

  public void Attack(Vector2 origin, Vector2 direction) {
    if (_bulletScene == null) {
      return;
    }
    var bullet = (Bullet)_bulletScene.Instantiate();
    bullet.Position = origin;
    bullet.Direction = direction;
    GetTree().CurrentScene.CallDeferred("add_child", bullet);
  }
}
