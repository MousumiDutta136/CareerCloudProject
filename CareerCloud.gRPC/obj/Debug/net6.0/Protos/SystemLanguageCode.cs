// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SystemLanguageCode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/SystemLanguageCode.proto</summary>
  public static partial class SystemLanguageCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/SystemLanguageCode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SystemLanguageCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvU3lzdGVtTGFuZ3VhZ2VDb2RlLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9l",
            "bXB0eS5wcm90byIlCg9MYW5ndUlkUmVxdWVzdDkSEgoKTGFuZ3VhZ2VJRBgB",
            "IAEoCSJKChJTeXN0ZW1MYW5ndWFnZUNvZGUSEgoKTGFuZ3VhZ2VJRBgBIAEo",
            "CRIMCgROYW1lGAIgASgJEhIKCk5hdGl2ZU5hbWUYAyABKAkiTwoTU3lzdGVt",
            "TGFuZ3VhZ2VDb2RlcxI4CgpTeXN0TGFuZ0NkGAEgAygLMiQuQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5TeXN0ZW1MYW5ndWFnZUNvZGUy5QMKGVN5c3RlbUxhbmd1YWdl",
            "Q29kZVNlcnZpY2USYAoVR2V0U3lzdGVtTGFuZ3VhZ2VDb2RlEiEuQ2FyZWVy",
            "Q2xvdWQuZ1JQQy5MYW5ndUlkUmVxdWVzdDkaJC5DYXJlZXJDbG91ZC5nUlBD",
            "LlN5c3RlbUxhbmd1YWdlQ29kZRJXChZHZXRTeXN0ZW1MYW5ndWFnZUNvZGVz",
            "EhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GiUuQ2FyZWVyQ2xvdWQuZ1JQQy5T",
            "eXN0ZW1MYW5ndWFnZUNvZGVzElcKFkFkZFN5c3RlbUxhbmd1YWdlQ29kZXMS",
            "JS5DYXJlZXJDbG91ZC5nUlBDLlN5c3RlbUxhbmd1YWdlQ29kZXMaFi5nb29n",
            "bGUucHJvdG9idWYuRW1wdHkSWQoYVXBkYXRlU3lzdGVtTGFuZ3VhZ2VDb2Rl",
            "EiUuQ2FyZWVyQ2xvdWQuZ1JQQy5TeXN0ZW1MYW5ndWFnZUNvZGVzGhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5ElkKGERlbGV0ZVN5c3RlbUxhbmd1YWdlQ29k",
            "ZRIlLkNhcmVlckNsb3VkLmdSUEMuU3lzdGVtTGFuZ3VhZ2VDb2RlcxoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuZ1JQQy5Qcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.LanguIdRequest9), global::CareerCloud.gRPC.Protos.LanguIdRequest9.Parser, new[]{ "LanguageID" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SystemLanguageCode), global::CareerCloud.gRPC.Protos.SystemLanguageCode.Parser, new[]{ "LanguageID", "Name", "NativeName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SystemLanguageCodes), global::CareerCloud.gRPC.Protos.SystemLanguageCodes.Parser, new[]{ "SystLangCd" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanguIdRequest9 : pb::IMessage<LanguIdRequest9>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanguIdRequest9> _parser = new pb::MessageParser<LanguIdRequest9>(() => new LanguIdRequest9());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LanguIdRequest9> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LanguIdRequest9() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LanguIdRequest9(LanguIdRequest9 other) : this() {
      languageID_ = other.languageID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LanguIdRequest9 Clone() {
      return new LanguIdRequest9(this);
    }

    /// <summary>Field number for the "LanguageID" field.</summary>
    public const int LanguageIDFieldNumber = 1;
    private string languageID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageID {
      get { return languageID_; }
      set {
        languageID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LanguIdRequest9);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LanguIdRequest9 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LanguageID != other.LanguageID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LanguageID.Length != 0) hash ^= LanguageID.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (LanguageID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LanguageID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LanguageID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LanguIdRequest9 other) {
      if (other == null) {
        return;
      }
      if (other.LanguageID.Length != 0) {
        LanguageID = other.LanguageID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            LanguageID = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            LanguageID = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SystemLanguageCode : pb::IMessage<SystemLanguageCode>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SystemLanguageCode> _parser = new pb::MessageParser<SystemLanguageCode>(() => new SystemLanguageCode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemLanguageCode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCode(SystemLanguageCode other) : this() {
      languageID_ = other.languageID_;
      name_ = other.name_;
      nativeName_ = other.nativeName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCode Clone() {
      return new SystemLanguageCode(this);
    }

    /// <summary>Field number for the "LanguageID" field.</summary>
    public const int LanguageIDFieldNumber = 1;
    private string languageID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageID {
      get { return languageID_; }
      set {
        languageID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NativeName" field.</summary>
    public const int NativeNameFieldNumber = 3;
    private string nativeName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NativeName {
      get { return nativeName_; }
      set {
        nativeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemLanguageCode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemLanguageCode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LanguageID != other.LanguageID) return false;
      if (Name != other.Name) return false;
      if (NativeName != other.NativeName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LanguageID.Length != 0) hash ^= LanguageID.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (NativeName.Length != 0) hash ^= NativeName.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (LanguageID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageID);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (NativeName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NativeName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LanguageID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageID);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (NativeName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NativeName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LanguageID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageID);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (NativeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NativeName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemLanguageCode other) {
      if (other == null) {
        return;
      }
      if (other.LanguageID.Length != 0) {
        LanguageID = other.LanguageID;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.NativeName.Length != 0) {
        NativeName = other.NativeName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            LanguageID = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            NativeName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            LanguageID = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            NativeName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SystemLanguageCodes : pb::IMessage<SystemLanguageCodes>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SystemLanguageCodes> _parser = new pb::MessageParser<SystemLanguageCodes>(() => new SystemLanguageCodes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemLanguageCodes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCodes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCodes(SystemLanguageCodes other) : this() {
      systLangCd_ = other.systLangCd_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCodes Clone() {
      return new SystemLanguageCodes(this);
    }

    /// <summary>Field number for the "SystLangCd" field.</summary>
    public const int SystLangCdFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.SystemLanguageCode> _repeated_systLangCd_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.SystemLanguageCode.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SystemLanguageCode> systLangCd_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SystemLanguageCode>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SystemLanguageCode> SystLangCd {
      get { return systLangCd_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemLanguageCodes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemLanguageCodes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!systLangCd_.Equals(other.systLangCd_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= systLangCd_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      systLangCd_.WriteTo(output, _repeated_systLangCd_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      systLangCd_.WriteTo(ref output, _repeated_systLangCd_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += systLangCd_.CalculateSize(_repeated_systLangCd_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemLanguageCodes other) {
      if (other == null) {
        return;
      }
      systLangCd_.Add(other.systLangCd_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            systLangCd_.AddEntriesFrom(input, _repeated_systLangCd_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            systLangCd_.AddEntriesFrom(ref input, _repeated_systLangCd_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
