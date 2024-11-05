using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ServerConexion : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;

    public Transform spawn;
    
    void Start()
    {
        //conecion al servidor
        //PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

 
    

    public override void OnJoinedRoom()
    {

        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, spawn.position, spawn.rotation);
        player.GetComponent<PhotonView>().RPC("SetNameText", RpcTarget.AllBuffered, PlayerPrefs.GetString("PlayerName"));
    }

}
