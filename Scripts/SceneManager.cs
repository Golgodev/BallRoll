using Godot;
using System;

public partial class SceneManager : Area3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void NextScene(Node3D node) {
		GetTree().ChangeSceneToFile("res://map_2.tscn");
	}
}
