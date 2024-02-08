using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class InventoryProcessor : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private ItemLibrary _itemLibrary;
    [SerializeField] private int _countAddedItems;
    [SerializeField] private GameObject _containerAddedItems;


    private void AddItem( Item item)
    {
        Item newitem = Instantiate(item, _containerAddedItems.transform);
        

        item.AddNewStackItem(_inventory.ListItem, newitem);


    }


    public void AddRandomItems()
    {
        for (int i = 0; i < _countAddedItems; i++) // цикл число тиков это сколько надо добавить предметов
        {
            int randomPos = Random.Range(0, _itemLibrary.AvailableItemList.Count); //рандомный ID предмета для добавления
            

            AddItem(_itemLibrary.AvailableItemList[randomPos]);
;



        }
    }
}
