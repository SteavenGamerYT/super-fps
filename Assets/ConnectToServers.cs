using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ConnectToServers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}