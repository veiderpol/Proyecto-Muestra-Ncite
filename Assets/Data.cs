using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;


public class Data : MonoBehaviour
{
    public static Data instance = null;
    GameObject objStoreController;
    StoreControl storeControl;
    public int monedas = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

}
