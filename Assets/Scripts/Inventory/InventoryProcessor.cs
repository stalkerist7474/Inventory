using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class InventoryProcessor : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private ItemLibrary _itemLibrary;


    private void AddItem( Item item)
    {
        item.AddValueStackItem(_inventory.ListItem, item);
    }

    private void Start()
    {
        foreach (var item in _itemLibrary.AvailableItemList)
        {
            AddItem(item);
        }
    }
}
