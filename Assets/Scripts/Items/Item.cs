using System.Collections;
using System.Collections.Generic;
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

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public Sprite Icon { get => _icon; set => _icon = value; }
    public int CountItem { get => _countItem; set => _countItem = value; }
    public int MaxInStack { get => _maxInStack; set => _maxInStack = value; }
    public ItemBaff ItemBaffType { get => _itemBaffType; set => _itemBaffType = value; }
    public int BaffValue { get => _baffValue; set => _baffValue = value; }

    //���������� ������ ����� ��������, ����� �������� ����������� � ��������� �� �����
    public void AddNewStackItem(List<Item> itemList, Item item)
    {

        itemList.Add(item);

        foreach (var obj in itemList)
        {

        }
    }
    //���������� ���������� ��������
    public void AddValueStackItem(List<Item> itemList, Item item)
    {

        

        foreach (var obj in itemList)
        {
            if (obj.Id == item.Id) //�������� ID
            {
                if (obj.CountItem == obj.MaxInStack) // �������� ���� ��������� ���������� �������� ��� ����� ��������� � �����
                {
                    AddNewStackItem(itemList, item);
                    return;
                }

                if (obj.CountItem < item.CountItem) //�������� ���� �� ����� � ���. ����� ��������
                {
                    obj.CountItem += item.CountItem;
                    return;
                }

                else                               //���������� ������� ���� �� ������, � ����� ���� ���������� ����������� ��������� � ��� ���� �� ����������
                {
                    int remains = 0;

                    remains = obj.MaxInStack - obj.CountItem;   //�������, �� ������� ����� ����� ��������� ����
                    obj.CountItem += remains;   

                    item.CountItem -= remains;                  //�������� ��������� �������� �� �� �������� ������� ��� �������� � ������������ ����

                    AddNewStackItem(itemList, item);

                }
            }
        }
    }
}
