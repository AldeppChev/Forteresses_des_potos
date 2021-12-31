using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    void Start()
    {
        menu.SetActive(false);
    }
}
