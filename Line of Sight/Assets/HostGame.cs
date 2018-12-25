﻿using UnityEngine.Networking;
using UnityEngine;

public class HostGame : MonoBehaviour {
    [SerializeField]
    private uint roomSize = 10;

    private string roomName;

    public void SetRoomName (string _name)
    {
        roomName = _name;
    }

    public void CreateRoom ()
    {
        if (roomName != "" && roomName != null) {
            Debug.Log("Creating Room: " + roomName + " with room for " + roomSize + " players");
        }
    }
}
