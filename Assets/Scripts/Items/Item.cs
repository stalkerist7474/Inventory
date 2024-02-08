using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _countItem;
    [SerializeField] private int _maxInStack;
    [SerializeField] private ItemBaff _itemBaffType;
    [SerializeField] private int _baffValue;
    [SerializeField] private string _typeItem;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public Sprite Icon { get => _icon; set => _icon = value; }
    public int CountItem { get => _countItem; set => _countItem = value; }
    public int MaxInStack { get => _maxInStack; set => _maxInStack = value; }
    public ItemBaff ItemBaffType { get => _itemBaffType; set => _itemBaffType = value; }
    public int BaffValue { get => _baffValue; set => _baffValue = value; }
    public string TypeItem { get => _typeItem; set => _typeItem = value; }



    //���������� ������ ����� ��������, ����� �������� ����������� � ��������� �� �����
    public void AddNewStackItem(List<Item> itemList, Item item)
    {
        
        itemList.Add(item);




    }
    //���������� ���������� ��������
    //public void AddValueStackItem(List<Item> itemList, Item item)
    //{

    //    if (itemList.Count == 0) //���� ������ ��������� ������
    //    {
    //        AddNewStackItem(itemList, item);
    //        return;
    //    }


    //    for (int i = 0; i < itemList.Count; i++)
    //    {
    //        Debug.Log("*");

    //        Debug.Log($"obj.Id-{itemList[i].Id}///////item.Id{item.Id}");

    //        if (itemList[i].Id == item.Id) //�������� ID
    //        {
    //            Debug.Log("*/*");
    //            if (itemList[i].CountItem == itemList[i].MaxInStack) // �������� ���� ��������� ���������� �������� ��� ����� ��������� � �����
    //            {
    //                AddNewStackItem(itemList, item);
    //                Debug.Log("***/1/***");
    //                return;
    //            }

    //            if ((itemList[i].MaxInStack - itemList[i].CountItem) < item.CountItem) //�������� ���� �� ����� � ���. ����� ��������
    //            {
    //                itemList[i].CountItem += item.CountItem;
    //                Debug.Log("***/2/***");
    //                return;
    //            }

    //            else                               //���������� ������� ���� �� ������, � ����� ���� ���������� ����������� ��������� � ��� ���� �� ����������
    //            {
    //                int remains = 0;

    //                remains = itemList[i].MaxInStack - itemList[i].CountItem;   //�������, �� ������� ����� ����� ��������� ����
    //                itemList[i].CountItem += remains;

    //                item.CountItem -= remains;                  //�������� ��������� �������� �� �� �������� ������� ��� �������� � ������������ ����
    //                Debug.Log("***/3/***");
    //                AddNewStackItem(itemList, item);
    //                Debug.Log("***/4/***");
    //            }
    //        }
    //        else { AddNewStackItem(itemList, item); }
    //    }



        
    //}
}
