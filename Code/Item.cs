using Godot;
using System;

public partial class Item : RigidBody3D, Interactable
{
    [Export]
    public string myName = "N/A";

    public virtual void Use() { }

    public virtual void OnPickup()
    {
        CollisionLayer &= ~Constants.PhysicsLayers.Collision;
        CollisionLayer &= ~Constants.PhysicsLayers.Interaction;
    }

    public virtual void OnDrop()
    {
        CollisionLayer |= Constants.PhysicsLayers.Collision;
        CollisionLayer |= Constants.PhysicsLayers.Interaction;
    }

    public void Interact(PlayerController aInteractor)
    {
        aInteractor.SwapHeldItem(this);
    }
}
