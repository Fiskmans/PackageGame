using Godot;
using System;

public partial class Spawner : Node3D
{
    [Export]
    PackedScene myItem { get; set; }

    [Export]
    Node myActivator { get; set; }

    public override void _Ready()
    {
        (myActivator as IHasActivation).GetActivationSource().myEvent += (sender) =>
        {
            Spawn();
        };
    }

    public void Spawn()
    {
        Node3D thing = (Node3D)myItem.Instantiate();
        GetTree().Root.AddChild(thing);
        thing.GlobalTransform = GlobalTransform;
    }
}
