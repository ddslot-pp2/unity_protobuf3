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

    //public delegate void Handler(IMessage Read);
    public Dictionary<Int16, Action<IMessage>> Handlers_;

    public void Init()
    {
        Deserializer_ = new Dictionary<Int16, DeserializeCallback>();
        Handlers_     = new Dictionary<Int16, Action<IMessage>>();

        SetDeserializer();
    }

    public void SetHandler<T>(Int16 opcode, Action<T> action)
    {
        Handlers_[opcode] = IMessage => action((T)IMessage);
    }

    public void Handle(Int16 opcode, byte[] Protobuf)
    {
        var Read = Deserializer_[opcode](Protobuf);

        Handlers_[opcode](Read);
    }

    public void SetDeserializer()
    {
        // 여기에 일단 등록
        Deserializer_[OpcodeToInt16(opcode.SC_LOG_IN)] = (byte[] Buf) =>
        {
            var Protobuf = LOBBY.SC_LOG_IN.Parser.ParseFrom(Buf);
            return Protobuf;
        };

        Deserializer_[OpcodeToInt16(opcode.SC_PING)] = (byte[] Buf) =>
        {
            var Protobuf = GAME.SC_PING.Parser.ParseFrom(Buf);
            return Protobuf;
        };
    }

    private Int16 OpcodeToInt16(Enum opcode)
    {
        return Convert.ToInt16(opcode);
    }
}
