using UnityEngine;

public class Item
{
    public Sprite Icon;
    public string Name;
    public int MaxStack;
    public bool CanStack;

    public virtual void Use()
    {
        Debug.Log("Use");
    }
}