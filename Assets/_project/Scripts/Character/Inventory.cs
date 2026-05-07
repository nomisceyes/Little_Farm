using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<Cell> HotBarItems = new();

    public Cell SelectedItem;
    private int _selectedIndex;
    private int _lastSelectedIndex = -1;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        HotBarItems.Add(new Cell(HotBarUI.Instance.GetCurrentUI(0), new Hoe()));
        HotBarItems.Add(new Cell(HotBarUI.Instance.GetCurrentUI(1), new Shovel()));

        foreach (Cell item in HotBarItems)
        {
            Debug.Log(item.Item.Name);
        }

        SelectedItem = HotBarItems[0];
    }

    private void Update()
    {
        for (int i = 0; i < Mathf.Min(6, HotBarItems.Count); i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                SelectSlot(i);
                return;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            SelectedItem?.Item.Use();
        }
    }

    private void SelectSlot(int index)
    {
        if (index < 0 || index >= HotBarItems.Count) return;
        
        if(_lastSelectedIndex >= 0 && _lastSelectedIndex < HotBarItems.Count)
            HotBarUI.Instance.ResetColor(_lastSelectedIndex);
        
        _selectedIndex = index;
        _lastSelectedIndex = index;

        if (SelectedItem != null)
        {
            HotBarUI.Instance.ChangeColor(_selectedIndex);
        }
    }
    
    private Cell GetItem()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            return GetCell(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            return GetCell(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            return GetCell(2);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            return GetCell(3);
        if (Input.GetKeyDown(KeyCode.Alpha5))
            return GetCell(4);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            return GetCell(5);

        return null;
    }

    private Cell GetCell(int index)
    {
        return HotBarItems[index];
    }
    
    public int GetIndexCell(Cell cell)
    {
        return HotBarItems.IndexOf(cell);
    }
}