using Godot;
using System;

public partial class CharacterTest : CharacterBody2D
{
    private float _speed = 300.0f;
    private float _jumpSpeed = -400.0f;

    public float Gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

    public override void _Ready()
    {
        var collision = GetNode<Area2D>("/root/Node2D/EnemyTest");
        collision.BodyEntered += onBodyEntered;
    }

    private void onBodyEntered(Node2D node2D)
    {
        
    }
    public override void _PhysicsProcess(double delta)
    {
        Vector2 velocity = Velocity;

        velocity.Y += Gravity * (float)delta;

        if(Input.IsActionJustPressed("jump") && IsOnFloor())
        {
            velocity.Y = _jumpSpeed;
        }

        float direction = Input.GetAxis("left", "right");
        velocity.X = direction * _speed;

        Velocity = velocity;
        MoveAndSlide();

    }
}
