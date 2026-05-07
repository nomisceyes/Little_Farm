using UnityEngine;

public class Shovel : Item
{
    public Shovel()
    {
        Name = "Shovel";
        CanStack = false;
    }
    
    public override void Use()
    {
        Debug.Log("Use Shovel");
    }
}