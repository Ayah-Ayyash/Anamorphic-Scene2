using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_18
{

    public class GenericsTest : MonoBehaviour
    {

        void Start()
        {
            GameContainer<string> container = new GameContainer<string>();
            container.SetItem("Healing Potion");

            Debug.Log("Stored item: " + container.GetItem());
            Debug.Log(GameUtils.DescribeItem(container.GetItem()));


        }
        }
}

    // GameContainer<string> G2 = new GameContainer<string>();
    // G1.SetItem("Item 2");
    // GameUtils.DescribeItem(G2.GetItem());

    // GameContainer<string> G3 = new GameContainer<string>();
    // G1.SetItem("Item 3");
    // GameUtils.DescribeItem(G3.GetItem());


    
