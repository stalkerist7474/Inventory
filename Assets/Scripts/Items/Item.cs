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

    //добавление нового стака предмета, такие предметы отсутствуют в инвентаре до этого
    public void AddNewStackItem(List<Item> itemList, Item item)
    {

        itemList.Add(item);

        foreach (var obj in itemList)
        {

        }
    }
    //добавление количества предмета
    public void AddValueStackItem(List<Item> itemList, Item item)
    {

        

        foreach (var obj in itemList)
        {
            if (obj.Id == item.Id) //проверка ID
            {
                if (obj.CountItem == obj.MaxInStack) // проверка если количетво найденного предмета уже равно максимуму в стаке
                {
                    AddNewStackItem(itemList, item);
                    return;
                }

                if (obj.CountItem < item.CountItem) //проверка есть ли место в сущ. стаке предмета
                {
                    obj.CountItem += item.CountItem;
                    return;
                }

                else                               //оставшийся вариант стак не полный, а также если количество добавляемых предметов в сущ стак не помещается
                {
                    int remains = 0;

                    remains = obj.MaxInStack - obj.CountItem;   //разница, то сколько нужно чтобы заполнить стак
                    obj.CountItem += remains;   

                    item.CountItem -= remains;                  //убавляем количесво предмета на ту величину которую уже добавили в существующий стак

                    AddNewStackItem(itemList, item);

                }
            }
        }
    }
}
