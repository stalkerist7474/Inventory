using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //список предметов в инвентаре "реальных"

    [SerializeField] private List<Item> _listItem = new List<Item>();

    public List<Item> ListItem { get => _listItem; set => _listItem = value; }
}
