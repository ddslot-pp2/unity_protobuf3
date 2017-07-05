﻿using Google.Protobuf;
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

        if (!Handlers_.ContainsKey(opcode))
            return;

        Handlers_[opcode](Read);
    }

    public void ResetAllHandler()
    {
        Handlers_.Clear();
    }

    public void SetDeserializer()
    {
        // 사용할 패킷 핸들러를 등록 스크립트를 통해서 소스코드를 자동생성 할 예정
        Deserializer_[OpcodeToInt16(opcode.SC_LOG_IN)] = (byte[] Buf) =>
        {
            return LOBBY.SC_LOG_IN.Parser.ParseFrom(Buf);
        };

        Deserializer_[OpcodeToInt16(opcode.SC_PING)] = (byte[] Buf) =>
        {
            return GAME.SC_PING.Parser.ParseFrom(Buf);
        };
    }

    private Int16 OpcodeToInt16(Enum opcode)
    {
        return Convert.ToInt16(opcode);
    }
}
