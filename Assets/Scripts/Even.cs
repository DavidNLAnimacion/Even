using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    void Start()
    {
        ShowEvenNumbers();
    }

    void ShowEvenNumbers()
    {
        for (int i = 0; i <= 100; i += 2)
        {
            Debug.Log(i);
        }
    }
}