using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ServerConexion : MonoBehaviourPunCallbacks
{
    public PhotonView player;

    public Transform spawn;
    void Start()
    {
        //conecion al servidor
        PhotonNetwork.ConnectUsingSettings();
    }

 
    

    public override void OnJoinedRoom()
    {

        PhotonNetwork.Instantiate(player.name, spawn.position, spawn.rotation);
    }

}
