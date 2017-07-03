using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProtobufHandler //: MonoBehaviour
{

    //public delegate void ProtobufCallback(Action<IMessage> read);
    public delegate IMessage DeserializeCallback(byte[] Buf);

    public Dictionary<Int16, DeserializeCallback> Deserializer_;
    //public Dictionary<Int16, Action<IMessage>> HandlerCallback_;

    public void Init()
    {
        Deserializer_    = new Dictionary<Int16, DeserializeCallback>();
        //HandlerCallback_ = new Dictionary<Int16, Action<IMessage>>();
        //SetDeserializer();
    }

    public void Handle(Int16 Opcode, byte[] Protobuf)
    {
        var read = Deserializer_[Opcode](Protobuf);

        /*
        var HandlerCallback = HandlerCallback_[Opcode];

        if (HandlerCallback != null)
        {
            HandlerCallback(read);
        }
        */
	}

    /*
    public void SetDeserializer()
    {
        // 여기에 일단 등록
        Deserializer_[(Int16)opcode.SC_LOG_IN] = (byte[] Buf) =>
        {
            var Protobuf = LOBBY.SC_LOG_IN.Parser.ParseFrom(Buf);
            return Protobuf;
        };   
    }

    public void SetHandler(Int16 Opcode, Action<IMessage> Handler)
    {
        HandlerCallback_[Opcode] = Handler;
    }
    */
}
