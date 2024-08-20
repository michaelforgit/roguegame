namespace roguegame;

using Godot;

public partial class Game : Control {
  public Button TestButton { get; private set; } = default!;
  public int ButtonPresses { get; private set; }

  private Events _events;


  public override void _Ready()
  {
    GD.Print("TEST");
    // _events = GetNode<Events>("/root/Events");
    // // Events.Instance.number = 20;
    Events.Instance.Spawn += OnSpawn;
    TestButton = GetNode<Button>("%TestButton");
  }

  public void OnTestButtonPressed() {
    ButtonPresses++;
    GD.Print(ButtonPresses);
  }
  public void OnSpawn(Vector2 origin)
  {
    GD.Print($"Item Spawned: {origin}");
  }
}
