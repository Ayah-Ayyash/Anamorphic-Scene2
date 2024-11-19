using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment_18
{

public class GameUtils
{

    public static string DescribeItem<T>(T something)

    {
        return "This item is " + something + ".";
        // Debug.Log("This item is " + something + ".");
    }

}
}