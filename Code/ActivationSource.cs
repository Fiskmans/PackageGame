using Godot;
using System;

public partial class ActivationSource
{
    public delegate void ActivationHandler(GodotObject asource);

    public event ActivationHandler myEvent;

    public void Activate(GodotObject aSender)
    {
        myEvent?.Invoke(aSender);
    }
}
