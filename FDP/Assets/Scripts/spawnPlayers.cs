using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Photon.Pun;

public class spawnPlayers : MonoBehaviour
{
    public GameObject playerGO;

    public Transform[] SpawnPoints;

    private void Awake()
    {
        playerGO = Resources.Load("player") as GameObject;

        Transform sp = SpawnPoints[0];
        if (!PhotonNetwork.IsMasterClient)
            sp = SpawnPoints[1];

        PhotonNetwork.Instantiate(playerGO.name, sp.position, Quaternion.identity);
    }
}
