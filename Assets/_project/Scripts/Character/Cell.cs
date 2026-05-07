using System;
using UnityEngine.UI;

[Serializable]
public class Cell
{
    public Image Background;
    public Item Item;

    public Cell(Image background, Item item)
    {
        Background = background;
        Item = item;
    }
}