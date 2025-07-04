using Godot;
using System;

public partial class PlayAnimationOnEvent : AnimationPlayer
{
    [Export]
    Node myTrigger { get; set; }
    [Export]
    string myAnimation { get; set; }

    public override void _Ready()
    {
        (myTrigger as IHasActivation).GetActivationSource().myEvent += (sender) =>
        {
            Play(myAnimation);
        };
    }
}
