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

    public void handler_SC_LOG_IN(LOBBY.SC_LOG_IN read)
    {
        Debug.Log("유부남 불륜");
    }

    public void Awake()
    {
    }

    public void RegisterPacketHandler()
    {
        //ProtobufManager.Instance().Handler().SetHandler<LOBBY.SC_LOG_IN>(200, handler_SC_LOG_IN);
        ProtobufManager.Instance().SetHandler<LOBBY.SC_LOG_IN>(opcode.SC_LOG_IN, handler_SC_LOG_IN);
    }

    void Start ()
    {
       
        ProtobufManager.Instance().Connect("127.0.0.1", 3000, onConnect, onDisconnect);
        RegisterPacketHandler();
    }
	
	// Update is called once per frame
	void Update ()
    {
        ProtobufManager.Instance().ProcessPacket();

    }

    void OnDestroy()
    {
        ProtobufManager.Instance().Destroy();
    }

}
