using Godot;
using System;

public partial class BoxTurnIn : Area3D
{
    [Export]
    float myConsumeSpeed = 1.0f;

    public override void _Ready()
    {
        BodyEntered += OnEnter;
    }
    public override void _PhysicsProcess(double aDelta)
    {
        foreach (Node child in GetChildren())
        {
            if (child is Box)
            {
                Box box = (Box)child;
                box.Transform = box.Transform.InterpolateWith(Transform3D.Identity, (float)aDelta * myConsumeSpeed);

                if (box.Transform.IsEqualApprox(Transform3D.Identity))
                {
                    Eat(box);
                }
            }
        }
    }

    private void OnEnter(Node3D body)
    {
        if (body is Box)
        {
            Consume((Box)body);
        }
    }

    private void Consume(Box aBox)
    {
        aBox.Reparent(this, true);

        aBox.Freeze = true;
    }

    private void Eat(Box aBox)
    {
        RemoveChild(aBox);
        aBox.QueueFree();
    }
}
