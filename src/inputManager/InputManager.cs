namespace roguegame;

using Godot;
using System;

public partial class InputManager : Node {
  private float _x;
  private float _y;
  private Vector2 _raw;
  private bool _attack;
  public void Process(double delta) {
    _x = Input.GetAxis("move_left", "move_right");
    _y = Input.GetAxis("move_up", "move_down");
    _raw = new Vector2(_x, _y);
  }

  public Vector2 Raw => _raw;
  public Vector2 Normalized => _raw.Normalized();
}
