using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerStats : MonoBehaviour
{
    public int life = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.L))
        {
            life--;
            Debug.Log("life T1 :" + life);
        }
    }
}
