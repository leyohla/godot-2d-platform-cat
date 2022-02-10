using Godot;
using System;

public class Player : KinematicBody2D
{
	public override void _Process(float delta) 
	{
		var direction = Vector3.Zero;
		
		if(Input.IsActionPressed("move_right")) {
			direction.x += 1f;
		}
	}
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
