using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = GetComponent<GameObject>();
        }

    }
}
