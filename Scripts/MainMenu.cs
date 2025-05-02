using Godot;
using System;

public partial class MainMenu : Node3D
{
	public void PlayGame() {
		GetTree().ChangeSceneToFile("res://Scenes/game.tscn");
	}

	public void ExitGame() {
		GetTree().Quit();
	}
}
