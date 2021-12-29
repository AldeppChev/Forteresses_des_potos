using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using Random = UnityEngine.Random;

public class photonINIT : MonoBehaviourPunCallbacks
{
    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("PUN : Client connected to Master");

        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("PUN : Client failed to join a random room. Creating one ...");
        string roomName = "";
        for (int i = 0; i < 10; i++)
            roomName += Random.Range(0, 9).ToString();
        RoomOptions rO = new RoomOptions();
        rO.IsVisible = true;
        rO.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(roomName, rO, TypedLobby.Default);
        Debug.Log("PUN : Room Created :)");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("PUN : Client joined the room #" + PhotonNetwork.CurrentRoom.Name);
    }
}