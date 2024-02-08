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
    //    for (int i = 0; i < _countAddedItems; i++) // ���� ����� ����� ��� ������� ���� �������� ���������
    //    {
    //        int randomId = Random.Range(1, _maxIdItemForRandom); //��������� ID �������� ��� ����������

    //        for (int y = 0; y < _itemLibrary.AvailableItemList.Count; y++) //������ �� ���������� ��������� ��� ���������� �������� � ���������
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
        for (int i = 0; i < _countAddedItems; i++) // ���� ����� ����� ��� ������� ���� �������� ���������
        {
            int randomPos = Random.Range(0, _itemLibrary.AvailableItemList.Count); //��������� ID �������� ��� ����������
            bool itemAdded = false;

            AddItem(_itemLibrary.AvailableItemList[randomPos]);
            itemAdded = true;
            break;



        }
    }
}
