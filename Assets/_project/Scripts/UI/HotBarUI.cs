using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotBarUI : MonoBehaviour
{
    public static HotBarUI Instance;

    public List<Image> ItemsUI;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void ChangeColor(int index)
    {
        ItemsUI[index].GetComponent<Image>().color = Color.yellow;
    }

    public void ResetColor(int index)
    {
        ItemsUI[index].GetComponent<Image>().color = Color.white;
    }
    
    public Image GetCurrentUI(int index) =>
        ItemsUI[index];
}