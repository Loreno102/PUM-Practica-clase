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
        if (nameInpunt.text.Length >= 1)
        {
            PhotonNetwork.NickName = nameInpunt.text;

            PlayerPrefs.SetString("PlayerName", nameInpunt.text);

            button.text = "Conectando al servidos";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {

        SceneManager.LoadScene("GameMultiplayer");

    }

}
