using Godot;
using System;

public partial class Player : Node
{
	public static int numberOfCoins;
	public static Label coinLabel;
	public static CanvasLayer winScreen;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		coinLabel = GetNode<Label>("/root/Game/Canvas/CoinText");
		winScreen = GetNode<CanvasLayer>("/root/Game/WonScreen");
	}

	public static void AddCoin(int amount) {
		numberOfCoins++;
		//coinLabel.Text = numberOfCoins.ToString();

		if(numberOfCoins >= 150) {
			winScreen.Visible = true;
		}
	}

	public void Dead(Node3D node) {
		if(node.IsInGroup("Player")) {
			GetTree().ReloadCurrentScene();
		}
	}
}
