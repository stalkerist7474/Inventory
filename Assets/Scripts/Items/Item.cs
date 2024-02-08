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



    //добавление нового стака предмета, такие предметы отсутствуют в инвентаре до этого
    public void AddNewStackItem(List<Item> itemList, Item item)
    {
        
        itemList.Add(item);




    }
    //добавление количества предмета
    //public void AddValueStackItem(List<Item> itemList, Item item)
    //{

    //    if (itemList.Count == 0) //если список инвентаря пустой
    //    {
    //        AddNewStackItem(itemList, item);
    //        return;
    //    }


    //    for (int i = 0; i < itemList.Count; i++)
    //    {
    //        Debug.Log("*");

    //        Debug.Log($"obj.Id-{itemList[i].Id}///////item.Id{item.Id}");

    //        if (itemList[i].Id == item.Id) //проверка ID
    //        {
    //            Debug.Log("*/*");
    //            if (itemList[i].CountItem == itemList[i].MaxInStack) // проверка если количетво найденного предмета уже равно максимуму в стаке
    //            {
    //                AddNewStackItem(itemList, item);
    //                Debug.Log("***/1/***");
    //                return;
    //            }

    //            if ((itemList[i].MaxInStack - itemList[i].CountItem) < item.CountItem) //проверка есть ли место в сущ. стаке предмета
    //            {
    //                itemList[i].CountItem += item.CountItem;
    //                Debug.Log("***/2/***");
    //                return;
    //            }

    //            else                               //оставшийся вариант стак не полный, а также если количество добавляемых предметов в сущ стак не помещается
    //            {
    //                int remains = 0;

    //                remains = itemList[i].MaxInStack - itemList[i].CountItem;   //разница, то сколько нужно чтобы заполнить стак
    //                itemList[i].CountItem += remains;

    //                item.CountItem -= remains;                  //убавляем количесво предмета на ту величину которую уже добавили в существующий стак
    //                Debug.Log("***/3/***");
    //                AddNewStackItem(itemList, item);
    //                Debug.Log("***/4/***");
    //            }
    //        }
    //        else { AddNewStackItem(itemList, item); }
    //    }



        
    //}
}
