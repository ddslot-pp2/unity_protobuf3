using Google.Protobuf;
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

    public void Handler_SC_LOG_IN(LOBBY.SC_LOG_IN read)
    {
        
    }

    public void Awake()
    {
        ProtobufManager.Instance().Connect("127.0.0.1", 3000, onConnect, onDisconnect);
        //ProtobufManager.Instance().Handler().SetHandler(20, Handler_SC_LOG_IN);
    }

    public class A
    {
        public virtual void Foo()
        {

        }
    }

    public delegate void custom_callback(A packet);



    void Start ()
    {
       
        ProtobufManager.Instance().Connect("127.0.0.1", 3000, onConnect, onDisconnect);
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
