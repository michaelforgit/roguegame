namespace roguegame;
using Godot;
using System;

public partial class Bullet : Area2D {
  private float _speed = 200;
  private Vector2 direction;
  private double _timer;

  public Vector2 Direction {
	get => direction;
	set => direction = value;
  }
  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta) {
	_timer += delta;
	if (_timer >= 1.5) {
	  QueueFree();
	}
  }

  public override void _PhysicsProcess(double delta) {
	// base._PhysicsProcess(delta);
	Position += direction * _speed * (float)delta;
	GD.Print(Position);
  }
}
