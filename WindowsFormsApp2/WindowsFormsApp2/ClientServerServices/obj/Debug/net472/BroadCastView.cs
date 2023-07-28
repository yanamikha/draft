// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/BroadCastView.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BroadCastView {

  /// <summary>Holder for reflection information generated from Protos/BroadCastView.proto</summary>
  public static partial class BroadCastViewReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/BroadCastView.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BroadCastViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90b3MvQnJvYWRDYXN0Vmlldy5wcm90bxINQnJvYWRDYXN0Vmlldxob",
            "Z29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhFQcm90b3MvVmlldy5wcm90",
            "bxoSUHJvdG9zL1Rva2VuLnByb3RvImMKD09wdGlvbmFsTWVzc2FnZRIpCgdN",
            "ZXNzYWdlGAEgASgLMhYuQnJvYWRDYXN0Vmlldy5NZXNzYWdlSAASFQoLTm90",
            "QU1lc3NhZ2UYAiABKAhIAEIOCgxSZXNwb25zZVR5cGUiGwoHTWVzc2FnZRIQ",
            "CghWUmVxdWVzdBgBIAEoCTKiAQoQQnJvYWRDYXN0U2VydmljZRJPChZTdWJz",
            "Y3JpYmVNZXNzYWdlU3RyZWFtEhMuYXV0aGVudGljaXR5LlRva2VuGh4uQnJv",
            "YWRDYXN0Vmlldy5PcHRpb25hbE1lc3NhZ2UwARI9CgtQb3N0TWVzc2FnZRIW",
            "LkJyb2FkQ2FzdFZpZXcuTWVzc2FnZRoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0",
            "eWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::View.ViewReflection.Descriptor, global::Authenticity.TokenReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BroadCastView.OptionalMessage), global::BroadCastView.OptionalMessage.Parser, new[]{ "Message", "NotAMessage" }, new[]{ "ResponseType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BroadCastView.Message), global::BroadCastView.Message.Parser, new[]{ "VRequest" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OptionalMessage : pb::IMessage<OptionalMessage> {
    private static readonly pb::MessageParser<OptionalMessage> _parser = new pb::MessageParser<OptionalMessage>(() => new OptionalMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OptionalMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BroadCastView.BroadCastViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OptionalMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OptionalMessage(OptionalMessage other) : this() {
      switch (other.ResponseTypeCase) {
        case ResponseTypeOneofCase.Message:
          Message = other.Message.Clone();
          break;
        case ResponseTypeOneofCase.NotAMessage:
          NotAMessage = other.NotAMessage;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OptionalMessage Clone() {
      return new OptionalMessage(this);
    }

    /// <summary>Field number for the "Message" field.</summary>
    public const int MessageFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BroadCastView.Message Message {
      get { return responseTypeCase_ == ResponseTypeOneofCase.Message ? (global::BroadCastView.Message) responseType_ : null; }
      set {
        responseType_ = value;
        responseTypeCase_ = value == null ? ResponseTypeOneofCase.None : ResponseTypeOneofCase.Message;
      }
    }

    /// <summary>Field number for the "NotAMessage" field.</summary>
    public const int NotAMessageFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NotAMessage {
      get { return responseTypeCase_ == ResponseTypeOneofCase.NotAMessage ? (bool) responseType_ : false; }
      set {
        responseType_ = value;
        responseTypeCase_ = ResponseTypeOneofCase.NotAMessage;
      }
    }

    private object responseType_;
    /// <summary>Enum of possible cases for the "ResponseType" oneof.</summary>
    public enum ResponseTypeOneofCase {
      None = 0,
      Message = 1,
      NotAMessage = 2,
    }
    private ResponseTypeOneofCase responseTypeCase_ = ResponseTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseTypeOneofCase ResponseTypeCase {
      get { return responseTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearResponseType() {
      responseTypeCase_ = ResponseTypeOneofCase.None;
      responseType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OptionalMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OptionalMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Message, other.Message)) return false;
      if (NotAMessage != other.NotAMessage) return false;
      if (ResponseTypeCase != other.ResponseTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (responseTypeCase_ == ResponseTypeOneofCase.Message) hash ^= Message.GetHashCode();
      if (responseTypeCase_ == ResponseTypeOneofCase.NotAMessage) hash ^= NotAMessage.GetHashCode();
      hash ^= (int) responseTypeCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (responseTypeCase_ == ResponseTypeOneofCase.Message) {
        output.WriteRawTag(10);
        output.WriteMessage(Message);
      }
      if (responseTypeCase_ == ResponseTypeOneofCase.NotAMessage) {
        output.WriteRawTag(16);
        output.WriteBool(NotAMessage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (responseTypeCase_ == ResponseTypeOneofCase.Message) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Message);
      }
      if (responseTypeCase_ == ResponseTypeOneofCase.NotAMessage) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OptionalMessage other) {
      if (other == null) {
        return;
      }
      switch (other.ResponseTypeCase) {
        case ResponseTypeOneofCase.Message:
          if (Message == null) {
            Message = new global::BroadCastView.Message();
          }
          Message.MergeFrom(other.Message);
          break;
        case ResponseTypeOneofCase.NotAMessage:
          NotAMessage = other.NotAMessage;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::BroadCastView.Message subBuilder = new global::BroadCastView.Message();
            if (responseTypeCase_ == ResponseTypeOneofCase.Message) {
              subBuilder.MergeFrom(Message);
            }
            input.ReadMessage(subBuilder);
            Message = subBuilder;
            break;
          }
          case 16: {
            NotAMessage = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Message : pb::IMessage<Message> {
    private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Message> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BroadCastView.BroadCastViewReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message(Message other) : this() {
      vRequest_ = other.vRequest_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Message Clone() {
      return new Message(this);
    }

    /// <summary>Field number for the "VRequest" field.</summary>
    public const int VRequestFieldNumber = 1;
    private string vRequest_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VRequest {
      get { return vRequest_; }
      set {
        vRequest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Message);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Message other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VRequest != other.VRequest) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VRequest.Length != 0) hash ^= VRequest.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (VRequest.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VRequest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VRequest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VRequest);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Message other) {
      if (other == null) {
        return;
      }
      if (other.VRequest.Length != 0) {
        VRequest = other.VRequest;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            VRequest = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code