using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using System;

public class NetworkSampleManager : MonoBehaviour {

    // 접속 완료 후 콜백
    public void onConnect()
    {
        Debug.Log("OnConnected called\n");
    }

    // 접속 종료시 콜백
    public void onDisconnect(SocketError ErrorCode)
    {
        Debug.Log("OnDisonnected called");
        Debug.Log("ErrorCode: " + ErrorCode);
    }

    // 이번 Scene에서 사용할 패킷 관련 핸들러
    public void handler_SC_LOG_IN(LOBBY.SC_LOG_IN read)
    {
        Debug.Log("recv handler_SC_LOG_IN");
        Debug.Log(read.Result);

        var Send = new GAME.CS_PING();
        Send.Timestamp = 200;

        ProtobufManager.Instance().Send(opcode.CS_PING, Send);
    }

    public void handler_SC_PING(GAME.SC_PING read)
    {
        Debug.Log("recv handler_SC_PING");
        Debug.Log(read.Timestamp);

        var Send = new LOBBY.CS_LOG_IN();
        Send.Id = "아잉오";
        Send.Password = "12345";

        ProtobufManager.Instance().Send(opcode.CS_LOG_IN, Send);
    }

    public void Awake()
    {
    }

    public void RegisterPacketHandler()
    {
        // 이번 Scene에 사용할 패킷관련 핸들러를 지정
        ProtobufManager.Instance().SetHandler<LOBBY.SC_LOG_IN>(opcode.SC_LOG_IN, handler_SC_LOG_IN);
        ProtobufManager.Instance().SetHandler<GAME.SC_PING>(opcode.SC_PING, handler_SC_PING);
    }

    void Start ()
    {
        RegisterPacketHandler();
        ProtobufManager.Instance().Connect("127.0.0.1", 3000, onConnect, onDisconnect);
    }
	
	// Update is called once per frame
	void Update ()
    {
        // 업데이트 할때마다 패킷을 처리해 핸들러를 호출
        ProtobufManager.Instance().ProcessPacket();

    }

    void OnDestroy()
    {
        ProtobufManager.Instance().Destroy();
    }

}
