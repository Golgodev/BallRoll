using Godot;
using System;

public partial class BallMovement : RigidBody3D
{
	[Export]
    public float Speed = 10.0f;
		[Export]
    public float JumpForce = 15.0f;

    private bool _isOnGround = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector3 direction = new Vector3();

        if (Input.IsActionPressed("ui_up"))
        {
            direction.Z -= 1;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            direction.Z += 1;
        }
        if (Input.IsActionPressed("ui_left"))
        {
            direction.X -= 1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            direction.X += 1;
        }

        if (direction != Vector3.Zero)
        {
            direction = direction.Normalized();
        }

        ApplyCentralImpulse(direction * Speed);
	}
}
