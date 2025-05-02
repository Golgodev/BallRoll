using Godot;
using System;

public partial class Pickable : Area3D
{
	[Export]
	public AudioStreamPlayer au;
	public void Add(Node3D node) {
		// zvuk se spustí ale objekt se hned smaže takže se nedokonží úplne
		AudioStreamPlayer auInst = au;
		au.GetParent().RemoveChild(auInst);

		Node scene = GetTree().CurrentScene;
		scene.AddChild(auInst);
		Player.AddCoin(1);
		QueueFree();
	}
}
