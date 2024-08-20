namespace roguegame;

using Godot;
using System;

public partial class DefaultWeapon : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

  public void shoot(Vector2 origin)
  {
    Events.Instance.EmitSignal(nameof(Events.SpawnEventHandler), origin);
  }
}
