using Godot;
using System;

public partial class Cube : CsgBox3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Rotate(new Vector3(1, 1, 1).Normalized(), (float)delta);
	}
}
