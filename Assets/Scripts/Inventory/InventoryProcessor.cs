using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class InventoryProcessor : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private ItemLibrary _itemLibrary;
    [SerializeField] private int _maxIdItemForRandom;
    [SerializeField] private int _countAddedItems;


    private void AddItem( Item item)
    {
        item.AddValueStackItem(_inventory.ListItem, item);

        Debug.Log($"AddItem-{item.Name}");

        Debug.Log($"_inventory.ListItem-{_inventory.ListItem[0].Name}");

        Debug.Log("1");
    }

    //public void AddRandomItems()
    //{
    //    for (int i = 0; i < _countAddedItems; i++) // цикл число тиков это сколько надо добавить предметов
    //    {
    //        int randomId = Random.Range(1, _maxIdItemForRandom); //рандомный ID предмета для добавления

    //        for (int y = 0; y < _itemLibrary.AvailableItemList.Count; y++) //проход по библиотеке предметов для добавления предмета в инвентарь
    //        {
    //            Debug.Log("2");

    //            if (_itemLibrary.AvailableItemList[y].Id == randomId)
    //            {
    //                Debug.Log("22");

    //                AddItem(_itemLibrary.AvailableItemList[y] );
    //                return;
    //            }
    //        }

    //    }
    //}


    public void AddRandomItems()
    {
        for (int i = 0; i < _countAddedItems; i++) // цикл число тиков это сколько надо добавить предметов
        {
            int randomPos = Random.Range(0, _itemLibrary.AvailableItemList.Count); //рандомный ID предмета для добавления
            bool itemAdded = false;

            AddItem(_itemLibrary.AvailableItemList[randomPos]);
            itemAdded = true;
            break;



        }
    }
}
