// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: LOBBY.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LOBBY {

  /// <summary>Holder for reflection information generated from LOBBY.proto</summary>
  public static partial class LOBBYReflection {

    #region Descriptor
    /// <summary>File descriptor for LOBBY.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LOBBYReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtMT0JCWS5wcm90bxIFTE9CQlkiKQoJQ1NfTE9HX0lOEgoKAmlkGAEgASgJ",
            "EhAKCHBhc3N3b3JkGAIgASgJIjoKCVNDX0xPR19JThIOCgZyZXN1bHQYASAB",
            "KAgSEQoJdGltZXN0YW1wGAIgASgDEgoKAmVjGAMgASgJIjYKD0NTX1NFVF9O",
            "SUNLTkFNRRIQCghuaWNrbmFtZRgBIAEoCRIRCglvYmplY3RfaWQYAiABKAUi",
            "NgoPU0NfU0VUX05JQ0tOQU1FEhAKCG5pY2tuYW1lGAEgASgJEhEKCW9iamVj",
            "dF9pZBgCIAEoBSo/CgxHYW1lRGF0YVR5cGUSDAoIYWxsX2RhdGEQABINCglp",
            "dGVtX2RhdGEQARISCg5oZXJvX3N0YXRfZGF0YRACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::LOBBY.GameDataType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LOBBY.CS_LOG_IN), global::LOBBY.CS_LOG_IN.Parser, new[]{ "Id", "Password" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LOBBY.SC_LOG_IN), global::LOBBY.SC_LOG_IN.Parser, new[]{ "Result", "Timestamp", "Ec" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LOBBY.CS_SET_NICKNAME), global::LOBBY.CS_SET_NICKNAME.Parser, new[]{ "Nickname", "ObjectId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LOBBY.SC_SET_NICKNAME), global::LOBBY.SC_SET_NICKNAME.Parser, new[]{ "Nickname", "ObjectId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum GameDataType {
    [pbr::OriginalName("all_data")] AllData = 0,
    [pbr::OriginalName("item_data")] ItemData = 1,
    [pbr::OriginalName("hero_stat_data")] HeroStatData = 2,
  }

  #endregion

  #region Messages
  public sealed partial class CS_LOG_IN : pb::IMessage<CS_LOG_IN> {
    private static readonly pb::MessageParser<CS_LOG_IN> _parser = new pb::MessageParser<CS_LOG_IN>(() => new CS_LOG_IN());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CS_LOG_IN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LOBBY.LOBBYReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_LOG_IN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_LOG_IN(CS_LOG_IN other) : this() {
      id_ = other.id_;
      password_ = other.password_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_LOG_IN Clone() {
      return new CS_LOG_IN(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CS_LOG_IN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CS_LOG_IN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Password != other.Password) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CS_LOG_IN other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SC_LOG_IN : pb::IMessage<SC_LOG_IN> {
    private static readonly pb::MessageParser<SC_LOG_IN> _parser = new pb::MessageParser<SC_LOG_IN>(() => new SC_LOG_IN());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SC_LOG_IN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LOBBY.LOBBYReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SC_LOG_IN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SC_LOG_IN(SC_LOG_IN other) : this() {
      result_ = other.result_;
      timestamp_ = other.timestamp_;
      ec_ = other.ec_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SC_LOG_IN Clone() {
      return new SC_LOG_IN(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private bool result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 2;
    private long timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "ec" field.</summary>
    public const int EcFieldNumber = 3;
    private string ec_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ec {
      get { return ec_; }
      set {
        ec_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SC_LOG_IN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SC_LOG_IN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (Timestamp != other.Timestamp) return false;
      if (Ec != other.Ec) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != false) hash ^= Result.GetHashCode();
      if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
      if (Ec.Length != 0) hash ^= Ec.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != false) {
        output.WriteRawTag(8);
        output.WriteBool(Result);
      }
      if (Timestamp != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Timestamp);
      }
      if (Ec.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ec);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != false) {
        size += 1 + 1;
      }
      if (Timestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
      }
      if (Ec.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ec);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SC_LOG_IN other) {
      if (other == null) {
        return;
      }
      if (other.Result != false) {
        Result = other.Result;
      }
      if (other.Timestamp != 0L) {
        Timestamp = other.Timestamp;
      }
      if (other.Ec.Length != 0) {
        Ec = other.Ec;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Result = input.ReadBool();
            break;
          }
          case 16: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 26: {
            Ec = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CS_SET_NICKNAME : pb::IMessage<CS_SET_NICKNAME> {
    private static readonly pb::MessageParser<CS_SET_NICKNAME> _parser = new pb::MessageParser<CS_SET_NICKNAME>(() => new CS_SET_NICKNAME());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CS_SET_NICKNAME> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LOBBY.LOBBYReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_SET_NICKNAME() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_SET_NICKNAME(CS_SET_NICKNAME other) : this() {
      nickname_ = other.nickname_;
      objectId_ = other.objectId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_SET_NICKNAME Clone() {
      return new CS_SET_NICKNAME(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 1;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "object_id" field.</summary>
    public const int ObjectIdFieldNumber = 2;
    private int objectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ObjectId {
      get { return objectId_; }
      set {
        objectId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CS_SET_NICKNAME);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CS_SET_NICKNAME other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      if (ObjectId != other.ObjectId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (ObjectId != 0) hash ^= ObjectId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Nickname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nickname);
      }
      if (ObjectId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ObjectId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (ObjectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObjectId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CS_SET_NICKNAME other) {
      if (other == null) {
        return;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.ObjectId != 0) {
        ObjectId = other.ObjectId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Nickname = input.ReadString();
            break;
          }
          case 16: {
            ObjectId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SC_SET_NICKNAME : pb::IMessage<SC_SET_NICKNAME> {
    private static readonly pb::MessageParser<SC_SET_NICKNAME> _parser = new pb::MessageParser<SC_SET_NICKNAME>(() => new SC_SET_NICKNAME());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SC_SET_NICKNAME> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LOBBY.LOBBYReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SC_SET_NICKNAME() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SC_SET_NICKNAME(SC_SET_NICKNAME other) : this() {
      nickname_ = other.nickname_;
      objectId_ = other.objectId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SC_SET_NICKNAME Clone() {
      return new SC_SET_NICKNAME(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 1;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "object_id" field.</summary>
    public const int ObjectIdFieldNumber = 2;
    private int objectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ObjectId {
      get { return objectId_; }
      set {
        objectId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SC_SET_NICKNAME);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SC_SET_NICKNAME other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      if (ObjectId != other.ObjectId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (ObjectId != 0) hash ^= ObjectId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Nickname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nickname);
      }
      if (ObjectId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ObjectId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (ObjectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObjectId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SC_SET_NICKNAME other) {
      if (other == null) {
        return;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.ObjectId != 0) {
        ObjectId = other.ObjectId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Nickname = input.ReadString();
            break;
          }
          case 16: {
            ObjectId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
