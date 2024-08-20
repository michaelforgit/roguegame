namespace roguegame;

using Godot;
using System;

public partial class Entity : CharacterBody2D {
  protected Vector2 _speed = new(100, 100);

  protected float _acceleration = 1000.00F;
  public override void _Ready() {

  }
  public override void _Process(double delta) {

  }

  public override void _PhysicsProcess(double delta) {

  }
}