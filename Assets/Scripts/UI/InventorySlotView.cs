using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotView : MonoBehaviour
{

    [SerializeField] private Item _item;
    [SerializeField] private Image _icon;
    [SerializeField] private Image _iconBaff;
    [SerializeField] private Image _defaultIcon;
    [SerializeField] private TMP_Text _valueCount;
    [SerializeField] private TMP_Text _valueBaff;

    public void Render(Item item)
    {
        _icon.sprite = item.Icon;
        _iconBaff.sprite = item.ItemBaffType.Icon;
        _valueCount.text = item.CountItem.ToString();
        _valueBaff.text = item.BaffValue.ToString();




    }
}
