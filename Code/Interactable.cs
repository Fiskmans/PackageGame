using Godot;
using System;

public partial interface Interactable 
{
    public virtual void Interact(PlayerController aInteractor) { }
}
