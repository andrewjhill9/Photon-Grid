﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using Global;

public class NetworkManagerPlus : NetworkManager {

	

    public override void OnServerSceneChanged(string sceneName)
    {
        /*if (sceneName == GlobalTags.GAME_SCREEN)
        {
            //NetworkManager.singleton.OnServerSceneChanged()
            //NetworkClient.Instance.Ready();
            //NetworkManager.singleton.SpawnObjects();
            //NetworkServer.SpawnObjects();
            GameObject[] numPlayers = GameObject.FindGameObjectsWithTag(GlobalTags.PLAYER); 
            GameObject[] go = (GameObject[])GameObject.FindObjectsOfType(gameObject.GetType());

            GameObject[] all = (GameObject[])GameObject.FindObjectsOfTypeAll(gameObject.GetType());

            Debug.Log(" ");
        }*/
    }
}
