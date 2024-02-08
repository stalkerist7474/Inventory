using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private InventorySlotView _slotView;
    [SerializeField] private GameObject _container;

    [SerializeField] private List<GameObject> _typeFilters;
    [SerializeField] private List<GameObject> _baffFilters;

    private void AddItemView(Item item)
    {
        var view = Instantiate(_slotView, _container.transform);

        view.Render(item);
        Debug.Log("4");
    }

    //довление всех предметов во вью
    public void AddAllItemsView()
    {
        foreach (var item in _inventory.ListItem)
        {
            AddItemView(item);
            Debug.Log("5");
        }
    }


    //сброс содержимого контейнера и применение фильтрации
    public void ApplyFilters()
    {

        ClearContainer();

        foreach (var item in _inventory.ListItem)
        {

            for (int i = 0; i < _typeFilters.Count; i++)
            {
                if (_typeFilters[i].name == item.TypeItem)
                {
                    bool status = _typeFilters[i].GetComponent<Toggle>().isOn; //фильтрация по типу
                    if (status)
                    {
                        //тип предмета подошел
                        if (CheckBaffFilter(item))
                        {
                            AddItemView(item);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }

    private bool CheckBaffFilter(Item item) //фильтрация по типу бафа
    {
        for (int i = 0; i < _baffFilters.Count; i++)
        {
            if (_baffFilters[i].name == item.ItemBaffType.Name)
            {
                bool status = _baffFilters[i].GetComponent<Toggle>().isOn;
                if (status)
                {
                    return true;
                }
                
            }
        }
        return false;
    }

    private void ClearContainer()
    {
        foreach(Transform item in _container.transform)
        {
            Destroy(item.gameObject);
        }
    }
}
