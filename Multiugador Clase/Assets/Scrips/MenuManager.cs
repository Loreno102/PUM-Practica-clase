using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField nameInpunt;

    public TMP_Text button;

    public void OnclickConnect()

    {
        //verificar si hay un boton para la conexion 

        if (nameInpunt.text.Length >= 1)
        {
            PhotonNetwork.NickName = nameInpunt.text;

            //guardar el nombre en un playerPref

            PlayerPrefs.SetString("PlayerName", nameInpunt.text);

            button.text = "Conectando al Servidor";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {

        SceneManager.LoadScene("GameMultiplayer");

    }

}
