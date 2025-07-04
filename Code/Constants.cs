using Godot;
using System;

public class Constants 
{
    public class PhysicsLayers
    {
        public static uint None = 0;
        public static uint Collision = 1 << 0;
        public static uint Interaction = 1 << 1;
    }
}
