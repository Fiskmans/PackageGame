using Godot;
using System;

public partial class Box : Item
{

    public override void Interact(GodotObject aInteractor)
    {
        base.Interact(aInteractor);
        GD.Print("You clicked on the box, proud of ya");
    }
}
