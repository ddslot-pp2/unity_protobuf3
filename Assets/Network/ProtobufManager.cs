using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProtobufManager
{

    public static ProtobufManager Instance_ = null;
    private Session Session_ = null;

    void Init()
    {
        Session_ = new Session();
    }

    public static ProtobufManager Instance()
    {
        if (Instance_ == null)
        {
            Instance_ = new ProtobufManager();
            Instance_.Init();
        }

        return Instance_;
    }

    public void Connect(String Host, int Port, Session.onConnectCallback ConnectCallback, Session.onDisconnectCallback DisconnectCallback, bool NoDelay = true)
    {
        Session_.Connect(Host, Port, ConnectCallback, DisconnectCallback, onRecvCallback);
    }

    public void onRecvCallback(MemoryStream buf)
    {
        /*
        Debug.Log("onRecvCallback called");
        Debug.Log("recv length: " + buf.Length);

        LOBBY.CS_LOG_IN send = new LOBBY.CS_LOG_IN();
        send.Id = "으으앙";
        send.Password = "12345";

        ProtobufManager.Instance().Send(opcode.CS_LOG_IN, send);
        */
        
    }

    public void Send(Enum Opcode, IMessage protobuf)
    {
        Send2(Convert.ToInt16(Opcode), protobuf);
    } 

    public void Send2(Int16 Opcode, IMessage Protobuf)
    {
        int ProtobufSize = Protobuf.CalculateSize();

        MemoryStream SendBuffer = new MemoryStream();
        
        Int16 BodySize = (Int16)(ProtobufSize + sizeof(Int16));

        SendBuffer.SetLength(BodySize + sizeof(Int16));

        SendBuffer.Write(BitConverter.GetBytes(BodySize), 0, sizeof(Int16));
        SendBuffer.Write(BitConverter.GetBytes(Opcode),   0, sizeof(Int16));

        SendBuffer.Seek(sizeof(Int16) * 2, 0);
        Protobuf.WriteTo(SendBuffer);

        SendBuffer.Seek(0, 0);
        Session_.Send(SendBuffer);
    }

    public void Destroy()
    {
        if (Session_ != null)
        {
            Session_.Disconnect();
            Session_ = null;
        }
    }
  
}
