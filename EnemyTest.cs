using Godot;
using System;

public partial class EnemyTest : Area2D
{
    [Signal]
    public delegate void hurtEventHandler();

    public override void _Ready()
    {
        var collision = GetNode<Area2D>("/root/Node2D/EnemyTest");
        collision.BodyEntered += onBodyEntered;
    }

    private void onBodyEntered(Node2D node2D)
    {
        //GD.Print("hit");
        EmitSignal(SignalName.hurt);
    }
}
