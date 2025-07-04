using Godot;
using System;

public partial class Interaction : StaticBody3D, IHasName, IInteractable, IHasActivation
{
    [Export]
    string myName = "N/A";
    ActivationSource myActivation = new ActivationSource();

    public ActivationSource GetActivationSource()
    {
        return myActivation;
    }

    public virtual void Interact(GodotObject aInteractor)
    {
        myActivation.Activate(aInteractor);
    }

    string IHasName.GetName()
    {
        return myName;
    }
}
