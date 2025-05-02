using Godot;
using System;

public partial class SpikeTrap : Node3D
{
	[Export]
	public float speed = 0.5f;
	[Export]
	public BallMovement player;
	[Export]
	public AnimationPlayer am;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		am.SpeedScale = speed;
	}

	public void Dead(Node3D node) {
		if(node.IsInGroup("Player")) {
			GetTree().ReloadCurrentScene();
		}
	}
}
