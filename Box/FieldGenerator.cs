using Godot;
using System;

public partial class FieldGenerator : Label3D
{
    [Export]
    string myPrefix = "";

    [Export]
    Godot.Collections.Array<string> myOptions = new Godot.Collections.Array<string> ();

    public override void _Ready()
    {
        Text = myPrefix + myOptions.PickRandom() ?? "";
    }
}
