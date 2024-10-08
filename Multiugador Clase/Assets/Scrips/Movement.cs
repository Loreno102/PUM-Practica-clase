using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviourPunCallbacks
{
    public float veloPlayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 desplasamiento = new Vector3(moveHorizontal, 0 , moveVertical) * veloPlayer * Time.deltaTime;

            transform.Translate(desplasamiento);

        }
    }
}
