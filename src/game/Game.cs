namespace roguegame;

using Godot;

public partial class Game : Control {
  public Button TestButton { get; private set; } = default!;
  public int ButtonPresses { get; private set; }



  public override void _Ready()
  {
    Events.Instance.number = 20;
    Events.SpawnEventHandler += OnSpawn;
    TestButton = GetNode<Button>("%TestButton");
  }

  public void OnTestButtonPressed() {
    ButtonPresses++;
    GD.Print(ButtonPresses);
  }
  private void OnSpawn(Vector2 origin)
  {
    GD.Print($"Item Spawned: {origin}");
  }
}
