﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class Go_level_3 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        //other.name should equal the root of your Player object
        if (other.CompareTag("Player"))
        {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(2);
        }
    }
}