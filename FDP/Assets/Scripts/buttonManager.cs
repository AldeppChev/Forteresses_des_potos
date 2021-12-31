using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    [SerializeField] GameObject menuM;
    [SerializeField] GameObject menuP;

    public void Play()
    {
        menuM.SetActive(false);
        menuP.SetActive(true);
    }

    public void Back()
    {
        menuM.SetActive(true);
        menuP.SetActive(false);
    }

    public void FindGame()
    {
        //Do something to notify the player we are looking for a game
        networkManager.JoinOrCreate();
    }
}
