using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_18
{
    public class GameContainer<T>
    {
        public T item;
        //to save an item in the GameContainer.
        public void SetItem(T newItem)
        {
            item = newItem;
          //  Debug.Log($"item = {item}");
        }
        //to return the saved item.
        public T GetItem()
        {
       //  Debug.Log($"item returned = {item}");

            return item;
        }
    }
}