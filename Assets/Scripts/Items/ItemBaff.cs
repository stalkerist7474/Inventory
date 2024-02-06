using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBaff : MonoBehaviour
{
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public Sprite Icon { get => _icon; set => _icon = value; }
}
