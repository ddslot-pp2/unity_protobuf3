using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProtobufManager// : MonoBehaviour
{

    public static ProtobufManager Instance_ = null;
    private Session Session_ = null;
    public Queue<MemoryStream> RecvQueue_ = null;

    public ProtobufHandler Handler_ = null;

    void Init()
    {
        Session_ = new Session();
        Handler_ = new ProtobufHandler();
        Handler_.Init();
        RecvQueue_ = new Queue<MemoryStream>();
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

    public void onRecvCallback(MemoryStream Buf)
    {
        RecvQueue_.Enqueue(Buf);
    }

    public void ProcessingPacket()
    {
        while (RecvQueue_.Count > 0)
        {
            var Buf = RecvQueue_.Dequeue();
            Int16 Opcode = BitConverter.ToInt16(Buf.GetBuffer(), 0);

            // 버퍼를 sizeof(Int16) 이동
            Buf.Seek(sizeof(Int16), 0);

            byte[] ProtobufBuf = Buf.GetBuffer();

            Handler_.Handle(Opcode, ProtobufBuf);
            /*
            var read = LOBBY.SC_LOG_IN.Parser.ParseFrom(Buf);
            if (processor_SC_LOG_IN != null)
            {
                processor_SC_LOG_IN(read);
            }
            */
            //LOBBY.SC_LOG_IN.Parser.ParseFrom(Buf);
        }
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

    public ProtobufHandler Handler()
    {
        if (Handler_ != null)
        {
            return Handler_;
        }

        return null;
    }

    public void SetHandler(Enum Opcode, Action<IMessage> callback)
    {
        Handler_.SetHandler(Convert.ToInt16(Opcode), callback);
    }

}
