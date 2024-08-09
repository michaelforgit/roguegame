namespace roguegame;

using Godot;
using scripts;

public partial class Entity : CharacterBody2D {

  public InputManager UsedInput = new();
  private Vector2 _speed = new(100, 100);

  private float _acceleration = 1000.00F;
  public override void _Ready() {
  }
  public override void _Process(double delta) {
    UsedInput.Process(delta);
  }

  public override void _PhysicsProcess(double delta) {
    if (GetMovementDirection() != new Vector2(0, 0)) {
      Velocity = Velocity.MoveToward(_speed * GetMovementDirection(), (float)(_acceleration * delta));
      MoveAndSlide();
    }
  }

  public Vector2 GetMovementDirection() {
    return UsedInput.GetNormalized();
  }
}
