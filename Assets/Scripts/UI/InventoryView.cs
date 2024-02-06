using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private InventorySlotView _slotView;
    [SerializeField] private GameObject _container;

    private void AddItemView(Item item)
    {
        var view = Instantiate(_slotView, _container.transform);

        view.Render(item);
    }


    public void AddAllItemsView()
    {
        foreach (var item in _inventory.ListItem)
        {
            AddItemView(item);
        }
    }
}
