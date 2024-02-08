using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLibrary : MonoBehaviour
{
    [SerializeField] private List<Item> _availableItemList = new List<Item>(); //Список для рандомного добавления доступных предметов

    public List<Item> AvailableItemList { get => _availableItemList; set => _availableItemList = value; }


    private void Awake()  //перед запуском рандомим количество предметов
    {
        foreach (var item in _availableItemList)
        {
            item.CountItem = Random.Range(1, 99);
            item.BaffValue = Random.Range(1, 99);
            Debug.Log("3");
        }
    }
}
