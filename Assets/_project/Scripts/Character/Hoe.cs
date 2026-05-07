using UnityEngine;

public class Hoe : Item
{
    public Hoe()
    {
        Name = "Hoe";
        CanStack = false;
    }

    public override void Use()
    {
        Debug.Log("Use Hoe");
    }
}