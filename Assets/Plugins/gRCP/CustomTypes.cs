// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: v1/custom_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace You.Facade.Proxies.v1 {

  /// <summary>Holder for reflection information generated from v1/custom_types.proto</summary>
  public static partial class CustomTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for v1/custom_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChV2MS9jdXN0b21fdHlwZXMucHJvdG8SCnlvdS5ycGMudjEaE2dvb2dsZS9z",
            "dHJ1Y3QucHJvdG8aFmdvb2dsZS90aW1lc3RhbXAucHJvdG8iWAoMTnVsbGFi",
            "bGVCb29sEi8KCW51bGxWYWx1ZRgBIAEoDjIaLmdvb2dsZS5wcm90b2J1Zi5O",
            "dWxsVmFsdWVIABIPCgV2YWx1ZRgCIAEoCEgAQgYKBGtpbmQiWgoOTnVsbGFi",
            "bGVTdHJpbmcSLwoJbnVsbFZhbHVlGAEgASgOMhouZ29vZ2xlLnByb3RvYnVm",
            "Lk51bGxWYWx1ZUgAEg8KBXZhbHVlGAIgASgJSABCBgoEa2luZCJaCg5OdWxs",
            "YWJsZVVJbnQ2NBIvCgludWxsVmFsdWUYASABKA4yGi5nb29nbGUucHJvdG9i",
            "dWYuTnVsbFZhbHVlSAASDwoFdmFsdWUYAiABKARIAEIGCgRraW5kIloKDk51",
            "bGxhYmxlVUludDMyEi8KCW51bGxWYWx1ZRgBIAEoDjIaLmdvb2dsZS5wcm90",
            "b2J1Zi5OdWxsVmFsdWVIABIPCgV2YWx1ZRgCIAEoDUgAQgYKBGtpbmQieQoR",
            "TnVsbGFibGVUaW1lU3RhbXASLwoJbnVsbFZhbHVlGAEgASgOMhouZ29vZ2xl",
            "LnByb3RvYnVmLk51bGxWYWx1ZUgAEisKBXZhbHVlGAIgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcEgAQgYKBGtpbmRCGKoCFVlvdS5GYWNhZGUu",
            "UHJveGllcy52MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::You.Facade.Proxies.v1.NullableBool), global::You.Facade.Proxies.v1.NullableBool.Parser, new[]{ "NullValue", "Value" }, new[]{ "Kind" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::You.Facade.Proxies.v1.NullableString), global::You.Facade.Proxies.v1.NullableString.Parser, new[]{ "NullValue", "Value" }, new[]{ "Kind" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::You.Facade.Proxies.v1.NullableUInt64), global::You.Facade.Proxies.v1.NullableUInt64.Parser, new[]{ "NullValue", "Value" }, new[]{ "Kind" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::You.Facade.Proxies.v1.NullableUInt32), global::You.Facade.Proxies.v1.NullableUInt32.Parser, new[]{ "NullValue", "Value" }, new[]{ "Kind" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::You.Facade.Proxies.v1.NullableTimeStamp), global::You.Facade.Proxies.v1.NullableTimeStamp.Parser, new[]{ "NullValue", "Value" }, new[]{ "Kind" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NullableBool : pb::IMessage<NullableBool> {
    private static readonly pb::MessageParser<NullableBool> _parser = new pb::MessageParser<NullableBool>(() => new NullableBool());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NullableBool> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::You.Facade.Proxies.v1.CustomTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableBool() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableBool(NullableBool other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableBool Clone() {
      return new NullableBool(this);
    }

    /// <summary>Field number for the "nullValue" field.</summary>
    public const int NullValueFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.NullValue NullValue {
      get { return kindCase_ == KindOneofCase.NullValue ? (global::Google.Protobuf.WellKnownTypes.NullValue) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.NullValue;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Value {
      get { return kindCase_ == KindOneofCase.Value ? (bool) kind_ : false; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Value;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      NullValue = 1,
      Value = 2,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NullableBool);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NullableBool other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NullValue != other.NullValue) return false;
      if (Value != other.Value) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.NullValue) hash ^= NullValue.GetHashCode();
      if (kindCase_ == KindOneofCase.Value) hash ^= Value.GetHashCode();
      hash ^= (int) kindCase_;
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
      if (kindCase_ == KindOneofCase.NullValue) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        output.WriteRawTag(16);
        output.WriteBool(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.NullValue) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NullableBool other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
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
          case 8: {
            kind_ = input.ReadEnum();
            kindCase_ = KindOneofCase.NullValue;
            break;
          }
          case 16: {
            Value = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NullableString : pb::IMessage<NullableString> {
    private static readonly pb::MessageParser<NullableString> _parser = new pb::MessageParser<NullableString>(() => new NullableString());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NullableString> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::You.Facade.Proxies.v1.CustomTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableString() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableString(NullableString other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableString Clone() {
      return new NullableString(this);
    }

    /// <summary>Field number for the "nullValue" field.</summary>
    public const int NullValueFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.NullValue NullValue {
      get { return kindCase_ == KindOneofCase.NullValue ? (global::Google.Protobuf.WellKnownTypes.NullValue) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.NullValue;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return kindCase_ == KindOneofCase.Value ? (string) kind_ : ""; }
      set {
        kind_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        kindCase_ = KindOneofCase.Value;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      NullValue = 1,
      Value = 2,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NullableString);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NullableString other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NullValue != other.NullValue) return false;
      if (Value != other.Value) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.NullValue) hash ^= NullValue.GetHashCode();
      if (kindCase_ == KindOneofCase.Value) hash ^= Value.GetHashCode();
      hash ^= (int) kindCase_;
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
      if (kindCase_ == KindOneofCase.NullValue) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        output.WriteRawTag(18);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.NullValue) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NullableString other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
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
          case 8: {
            kind_ = input.ReadEnum();
            kindCase_ = KindOneofCase.NullValue;
            break;
          }
          case 18: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NullableUInt64 : pb::IMessage<NullableUInt64> {
    private static readonly pb::MessageParser<NullableUInt64> _parser = new pb::MessageParser<NullableUInt64>(() => new NullableUInt64());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NullableUInt64> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::You.Facade.Proxies.v1.CustomTypesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableUInt64() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableUInt64(NullableUInt64 other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableUInt64 Clone() {
      return new NullableUInt64(this);
    }

    /// <summary>Field number for the "nullValue" field.</summary>
    public const int NullValueFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.NullValue NullValue {
      get { return kindCase_ == KindOneofCase.NullValue ? (global::Google.Protobuf.WellKnownTypes.NullValue) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.NullValue;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Value {
      get { return kindCase_ == KindOneofCase.Value ? (ulong) kind_ : 0UL; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Value;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      NullValue = 1,
      Value = 2,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NullableUInt64);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NullableUInt64 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NullValue != other.NullValue) return false;
      if (Value != other.Value) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.NullValue) hash ^= NullValue.GetHashCode();
      if (kindCase_ == KindOneofCase.Value) hash ^= Value.GetHashCode();
      hash ^= (int) kindCase_;
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
      if (kindCase_ == KindOneofCase.NullValue) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        output.WriteRawTag(16);
        output.WriteUInt64(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.NullValue) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NullableUInt64 other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
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
          case 8: {
            kind_ = input.ReadEnum();
            kindCase_ = KindOneofCase.NullValue;
            break;
          }
          case 16: {
            Value = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NullableUInt32 : pb::IMessage<NullableUInt32> {
    private static readonly pb::MessageParser<NullableUInt32> _parser = new pb::MessageParser<NullableUInt32>(() => new NullableUInt32());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NullableUInt32> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::You.Facade.Proxies.v1.CustomTypesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableUInt32() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableUInt32(NullableUInt32 other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableUInt32 Clone() {
      return new NullableUInt32(this);
    }

    /// <summary>Field number for the "nullValue" field.</summary>
    public const int NullValueFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.NullValue NullValue {
      get { return kindCase_ == KindOneofCase.NullValue ? (global::Google.Protobuf.WellKnownTypes.NullValue) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.NullValue;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Value {
      get { return kindCase_ == KindOneofCase.Value ? (uint) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Value;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      NullValue = 1,
      Value = 2,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NullableUInt32);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NullableUInt32 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NullValue != other.NullValue) return false;
      if (Value != other.Value) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.NullValue) hash ^= NullValue.GetHashCode();
      if (kindCase_ == KindOneofCase.Value) hash ^= Value.GetHashCode();
      hash ^= (int) kindCase_;
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
      if (kindCase_ == KindOneofCase.NullValue) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        output.WriteRawTag(16);
        output.WriteUInt32(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.NullValue) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NullableUInt32 other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value;
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
          case 8: {
            kind_ = input.ReadEnum();
            kindCase_ = KindOneofCase.NullValue;
            break;
          }
          case 16: {
            Value = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NullableTimeStamp : pb::IMessage<NullableTimeStamp> {
    private static readonly pb::MessageParser<NullableTimeStamp> _parser = new pb::MessageParser<NullableTimeStamp>(() => new NullableTimeStamp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NullableTimeStamp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::You.Facade.Proxies.v1.CustomTypesReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableTimeStamp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableTimeStamp(NullableTimeStamp other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          Value = other.Value.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NullableTimeStamp Clone() {
      return new NullableTimeStamp(this);
    }

    /// <summary>Field number for the "nullValue" field.</summary>
    public const int NullValueFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.NullValue NullValue {
      get { return kindCase_ == KindOneofCase.NullValue ? (global::Google.Protobuf.WellKnownTypes.NullValue) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.NullValue;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Value {
      get { return kindCase_ == KindOneofCase.Value ? (global::Google.Protobuf.WellKnownTypes.Timestamp) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.Value;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      NullValue = 1,
      Value = 2,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NullableTimeStamp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NullableTimeStamp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NullValue != other.NullValue) return false;
      if (!object.Equals(Value, other.Value)) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.NullValue) hash ^= NullValue.GetHashCode();
      if (kindCase_ == KindOneofCase.Value) hash ^= Value.GetHashCode();
      hash ^= (int) kindCase_;
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
      if (kindCase_ == KindOneofCase.NullValue) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.NullValue) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NullValue);
      }
      if (kindCase_ == KindOneofCase.Value) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NullableTimeStamp other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.NullValue:
          NullValue = other.NullValue;
          break;
        case KindOneofCase.Value:
          if (Value == null) {
            Value = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          Value.MergeFrom(other.Value);
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
          case 8: {
            kind_ = input.ReadEnum();
            kindCase_ = KindOneofCase.NullValue;
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.Timestamp subBuilder = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            if (kindCase_ == KindOneofCase.Value) {
              subBuilder.MergeFrom(Value);
            }
            input.ReadMessage(subBuilder);
            Value = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
