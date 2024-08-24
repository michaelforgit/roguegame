namespace roguegame;

using Godot;
using System;

public partial class Events : Node {
  [Signal]
  public delegate void SpawnEventHandler(Vector2 origin);
  // Called when the node enters the scene tree for the first time.

  public static Events Instance { get; private set; }

  // public int number = 5;
  public override void _Ready() {
    Instance = this;
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta) {
  }
}
