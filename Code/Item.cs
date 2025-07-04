using Godot;
using System;

public partial class Item : RigidBody3D, IHasName, IInteractable
{
    [Export]
    string myName = "N/A";

    
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

    public virtual void Interact(GodotObject aInteractor)
    {
        (aInteractor as PlayerController).SwapHeldItem(this);
    }

    string IHasName.GetName()
    {
        return myName;
    }
}
