using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using System;

public class NetworkSampleManager : MonoBehaviour {

    //Session session_;

    public void onConnect()
    {
        Debug.Log("OnConnected called\n");
    }

    public void onDisconnect(SocketError ErrorCode)
    {
        Debug.Log("OnDisonnected called");
        Debug.Log("ErrorCode: " + ErrorCode);
    }

    public void Awake()
    {
        ProtobufManager.Instance().Connect("127.0.0.1", 3000, onConnect, onDisconnect);
    }

    void Start ()
    {
        //ProtobufManager.Instance().Connect("127.0.0.1", 3000, onConnect, onDisconnect, onRecvCallback);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnDestroy()
    {
        ProtobufManager.Instance().Destroy();
    }

}
