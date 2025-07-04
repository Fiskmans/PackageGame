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

        CollisionLayer &= ~Constants.PhysicsLayers.Collision;

        Freeze = true;
    }

    public virtual void OnDrop()
    {
        CollisionLayer |= Constants.PhysicsLayers.Collision;
        CollisionLayer |= Constants.PhysicsLayers.Interaction;

        CollisionLayer |= Constants.PhysicsLayers.Collision;

        Freeze = false;
    }

    public virtual void Interact(PlayerController aInteractor)
    {
        aInteractor.SwapHeldItem(this);
    }
}
