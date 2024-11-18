using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Parameter : MonoBehaviour
{
    private void Start()
    {
        printLines("Hi", "Hello", "Bye", "Baby");
    }

    private void printLines(params string[] strArr)
    {
        foreach(string str in strArr)
        {
            print(str);
        }
    }
}
