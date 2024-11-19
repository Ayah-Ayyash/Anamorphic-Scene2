using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potionsInventory = new Inventory();
        Inventory elixirsInventory = new Inventory();

       
        potionsInventory.AddItem("Healing Potion");
        potionsInventory.AddItem("Strength Potion");

        
        elixirsInventory.AddItem("Elixir");
        elixirsInventory.AddItem("Dark Elixir");

       
        Inventory combinedInventory = potionsInventory + elixirsInventory;

       
        combinedInventory.ShowItems();
    }


}
