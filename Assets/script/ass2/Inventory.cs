using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory

{

    private List<string> itemNames = new List<string>();
    public void AddItem(string item)
    {
        itemNames.Add(item);
        Debug.Log(item + " is added");
    }
    public void ShowItems()
    {
        foreach (string item in itemNames)
        {
            Debug.Log(item);
        }
    }

    public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory newInventory = new Inventory();  
        foreach (var item in inv1.itemNames)
        {
            newInventory.AddItem(item);
        }

        foreach (var item in inv2.itemNames)
        {
            newInventory.AddItem(item);
        }

        return newInventory;  
    }
}
    