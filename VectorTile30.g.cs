// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: vector_tile3.0.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Example {

  /// <summary>Holder for reflection information generated from vector_tile3.0.proto</summary>
  public static partial class VectorTile30Reflection {

    #region Descriptor
    /// <summary>File descriptor for vector_tile3.0.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VectorTile30Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChR2ZWN0b3JfdGlsZTMuMC5wcm90bxILdmVjdG9yX3RpbGUikAQKBFRpbGUS",
            "JwoGbGF5ZXJzGAMgAygLMhcudmVjdG9yX3RpbGUuVGlsZS5MYXllchqXAQoF",
            "VmFsdWUSFAoMc3RyaW5nX3ZhbHVlGAEgASgJEhMKC2Zsb2F0X3ZhbHVlGAIg",
            "ASgCEhQKDGRvdWJsZV92YWx1ZRgDIAEoARIRCglpbnRfdmFsdWUYBCABKAMS",
            "EgoKdWludF92YWx1ZRgFIAEoBBISCgpzaW50X3ZhbHVlGAYgASgSEhIKCmJv",
            "b2xfdmFsdWUYByABKAgaZwoHRmVhdHVyZRIKCgJpZBgBIAEoBBIQCgR0YWdz",
            "GAIgAygNQgIQARIoCgR0eXBlGAMgASgOMhoudmVjdG9yX3RpbGUuVGlsZS5H",
            "ZW9tVHlwZRIUCghnZW9tZXRyeRgEIAMoDUICEAEamgEKBUxheWVyEg8KB3Zl",
            "cnNpb24YDyABKA0SDAoEbmFtZRgBIAEoCRIrCghmZWF0dXJlcxgCIAMoCzIZ",
            "LnZlY3Rvcl90aWxlLlRpbGUuRmVhdHVyZRIMCgRrZXlzGAMgAygJEicKBnZh",
            "bHVlcxgEIAMoCzIXLnZlY3Rvcl90aWxlLlRpbGUuVmFsdWUSDgoGZXh0ZW50",
            "GAUgASgNIj8KCEdlb21UeXBlEgsKB1VOS05PV04QABIJCgVQT0lOVBABEg4K",
            "CkxJTkVTVFJJTkcQAhILCgdQT0xZR09OEANCDEgDqgIHRXhhbXBsZWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Example.Tile), global::Example.Tile.Parser, new[]{ "Layers" }, null, new[]{ typeof(global::Example.Tile.Types.GeomType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Example.Tile.Types.Value), global::Example.Tile.Types.Value.Parser, new[]{ "StringValue", "FloatValue", "DoubleValue", "IntValue", "UintValue", "SintValue", "BoolValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Example.Tile.Types.Feature), global::Example.Tile.Types.Feature.Parser, new[]{ "Id", "Tags", "Type", "Geometry" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Example.Tile.Types.Layer), global::Example.Tile.Types.Layer.Parser, new[]{ "Version", "Name", "Features", "Keys", "Values", "Extent" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Tile : pb::IMessage<Tile> {
    private static readonly pb::MessageParser<Tile> _parser = new pb::MessageParser<Tile>(() => new Tile());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Tile> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Example.VectorTile30Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tile() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tile(Tile other) : this() {
      layers_ = other.layers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tile Clone() {
      return new Tile(this);
    }

    /// <summary>Field number for the "layers" field.</summary>
    public const int LayersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Example.Tile.Types.Layer> _repeated_layers_codec
        = pb::FieldCodec.ForMessage(26, global::Example.Tile.Types.Layer.Parser);
    private readonly pbc::RepeatedField<global::Example.Tile.Types.Layer> layers_ = new pbc::RepeatedField<global::Example.Tile.Types.Layer>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Example.Tile.Types.Layer> Layers {
      get { return layers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Tile);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Tile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!layers_.Equals(other.layers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= layers_.GetHashCode();
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
      layers_.WriteTo(output, _repeated_layers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += layers_.CalculateSize(_repeated_layers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Tile other) {
      if (other == null) {
        return;
      }
      layers_.Add(other.layers_);
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
          case 26: {
            layers_.AddEntriesFrom(input, _repeated_layers_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Tile message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// GeomType is described in section 4.3.4 of the specification
      /// </summary>
      public enum GeomType {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("POINT")] Point = 1,
        [pbr::OriginalName("LINESTRING")] Linestring = 2,
        [pbr::OriginalName("POLYGON")] Polygon = 3,
      }

      public sealed partial class Value : pb::IMessage<Value> {
        private static readonly pb::MessageParser<Value> _parser = new pb::MessageParser<Value>(() => new Value());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Value> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Example.Tile.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Value() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Value(Value other) : this() {
          stringValue_ = other.stringValue_;
          floatValue_ = other.floatValue_;
          doubleValue_ = other.doubleValue_;
          intValue_ = other.intValue_;
          uintValue_ = other.uintValue_;
          sintValue_ = other.sintValue_;
          boolValue_ = other.boolValue_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Value Clone() {
          return new Value(this);
        }

        /// <summary>Field number for the "string_value" field.</summary>
        public const int StringValueFieldNumber = 1;
        private string stringValue_ = "";
        /// <summary>
        /// Exactly one of these values must be present in a valid message
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string StringValue {
          get { return stringValue_; }
          set {
            stringValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "float_value" field.</summary>
        public const int FloatValueFieldNumber = 2;
        private float floatValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float FloatValue {
          get { return floatValue_; }
          set {
            floatValue_ = value;
          }
        }

        /// <summary>Field number for the "double_value" field.</summary>
        public const int DoubleValueFieldNumber = 3;
        private double doubleValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double DoubleValue {
          get { return doubleValue_; }
          set {
            doubleValue_ = value;
          }
        }

        /// <summary>Field number for the "int_value" field.</summary>
        public const int IntValueFieldNumber = 4;
        private long intValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long IntValue {
          get { return intValue_; }
          set {
            intValue_ = value;
          }
        }

        /// <summary>Field number for the "uint_value" field.</summary>
        public const int UintValueFieldNumber = 5;
        private ulong uintValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong UintValue {
          get { return uintValue_; }
          set {
            uintValue_ = value;
          }
        }

        /// <summary>Field number for the "sint_value" field.</summary>
        public const int SintValueFieldNumber = 6;
        private long sintValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long SintValue {
          get { return sintValue_; }
          set {
            sintValue_ = value;
          }
        }

        /// <summary>Field number for the "bool_value" field.</summary>
        public const int BoolValueFieldNumber = 7;
        private bool boolValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool BoolValue {
          get { return boolValue_; }
          set {
            boolValue_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Value);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Value other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (StringValue != other.StringValue) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleValue, other.DoubleValue)) return false;
          if (IntValue != other.IntValue) return false;
          if (UintValue != other.UintValue) return false;
          if (SintValue != other.SintValue) return false;
          if (BoolValue != other.BoolValue) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (StringValue.Length != 0) hash ^= StringValue.GetHashCode();
          if (FloatValue != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
          if (DoubleValue != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleValue);
          if (IntValue != 0L) hash ^= IntValue.GetHashCode();
          if (UintValue != 0UL) hash ^= UintValue.GetHashCode();
          if (SintValue != 0L) hash ^= SintValue.GetHashCode();
          if (BoolValue != false) hash ^= BoolValue.GetHashCode();
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
          if (StringValue.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(StringValue);
          }
          if (FloatValue != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(FloatValue);
          }
          if (DoubleValue != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(DoubleValue);
          }
          if (IntValue != 0L) {
            output.WriteRawTag(32);
            output.WriteInt64(IntValue);
          }
          if (UintValue != 0UL) {
            output.WriteRawTag(40);
            output.WriteUInt64(UintValue);
          }
          if (SintValue != 0L) {
            output.WriteRawTag(48);
            output.WriteSInt64(SintValue);
          }
          if (BoolValue != false) {
            output.WriteRawTag(56);
            output.WriteBool(BoolValue);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (StringValue.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
          }
          if (FloatValue != 0F) {
            size += 1 + 4;
          }
          if (DoubleValue != 0D) {
            size += 1 + 8;
          }
          if (IntValue != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(IntValue);
          }
          if (UintValue != 0UL) {
            size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UintValue);
          }
          if (SintValue != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeSInt64Size(SintValue);
          }
          if (BoolValue != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Value other) {
          if (other == null) {
            return;
          }
          if (other.StringValue.Length != 0) {
            StringValue = other.StringValue;
          }
          if (other.FloatValue != 0F) {
            FloatValue = other.FloatValue;
          }
          if (other.DoubleValue != 0D) {
            DoubleValue = other.DoubleValue;
          }
          if (other.IntValue != 0L) {
            IntValue = other.IntValue;
          }
          if (other.UintValue != 0UL) {
            UintValue = other.UintValue;
          }
          if (other.SintValue != 0L) {
            SintValue = other.SintValue;
          }
          if (other.BoolValue != false) {
            BoolValue = other.BoolValue;
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
                StringValue = input.ReadString();
                break;
              }
              case 21: {
                FloatValue = input.ReadFloat();
                break;
              }
              case 25: {
                DoubleValue = input.ReadDouble();
                break;
              }
              case 32: {
                IntValue = input.ReadInt64();
                break;
              }
              case 40: {
                UintValue = input.ReadUInt64();
                break;
              }
              case 48: {
                SintValue = input.ReadSInt64();
                break;
              }
              case 56: {
                BoolValue = input.ReadBool();
                break;
              }
            }
          }
        }

      }

      public sealed partial class Feature : pb::IMessage<Feature> {
        private static readonly pb::MessageParser<Feature> _parser = new pb::MessageParser<Feature>(() => new Feature());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Feature> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Example.Tile.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Feature() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Feature(Feature other) : this() {
          id_ = other.id_;
          tags_ = other.tags_.Clone();
          type_ = other.type_;
          geometry_ = other.geometry_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Feature Clone() {
          return new Feature(this);
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;
        private ulong id_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong Id {
          get { return id_; }
          set {
            id_ = value;
          }
        }

        /// <summary>Field number for the "tags" field.</summary>
        public const int TagsFieldNumber = 2;
        private static readonly pb::FieldCodec<uint> _repeated_tags_codec
            = pb::FieldCodec.ForUInt32(18);
        private readonly pbc::RepeatedField<uint> tags_ = new pbc::RepeatedField<uint>();
        /// <summary>
        /// Tags of this feature are encoded as repeated pairs of
        /// integers.
        /// A detailed description of tags is located in sections
        /// 4.2 and 4.4 of the specification
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<uint> Tags {
          get { return tags_; }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 3;
        private global::Example.Tile.Types.GeomType type_ = 0;
        /// <summary>
        /// The type of geometry stored in this feature.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Example.Tile.Types.GeomType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "geometry" field.</summary>
        public const int GeometryFieldNumber = 4;
        private static readonly pb::FieldCodec<uint> _repeated_geometry_codec
            = pb::FieldCodec.ForUInt32(34);
        private readonly pbc::RepeatedField<uint> geometry_ = new pbc::RepeatedField<uint>();
        /// <summary>
        /// Contains a stream of commands and parameters (vertices).
        /// A detailed description on geometry encoding is located in
        /// section 4.3 of the specification.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<uint> Geometry {
          get { return geometry_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Feature);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Feature other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Id != other.Id) return false;
          if(!tags_.Equals(other.tags_)) return false;
          if (Type != other.Type) return false;
          if(!geometry_.Equals(other.geometry_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Id != 0UL) hash ^= Id.GetHashCode();
          hash ^= tags_.GetHashCode();
          if (Type != 0) hash ^= Type.GetHashCode();
          hash ^= geometry_.GetHashCode();
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
          if (Id != 0UL) {
            output.WriteRawTag(8);
            output.WriteUInt64(Id);
          }
          tags_.WriteTo(output, _repeated_tags_codec);
          if (Type != 0) {
            output.WriteRawTag(24);
            output.WriteEnum((int) Type);
          }
          geometry_.WriteTo(output, _repeated_geometry_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Id != 0UL) {
            size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
          }
          size += tags_.CalculateSize(_repeated_tags_codec);
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          size += geometry_.CalculateSize(_repeated_geometry_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Feature other) {
          if (other == null) {
            return;
          }
          if (other.Id != 0UL) {
            Id = other.Id;
          }
          tags_.Add(other.tags_);
          if (other.Type != 0) {
            Type = other.Type;
          }
          geometry_.Add(other.geometry_);
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
                Id = input.ReadUInt64();
                break;
              }
              case 18:
              case 16: {
                tags_.AddEntriesFrom(input, _repeated_tags_codec);
                break;
              }
              case 24: {
                type_ = (global::Example.Tile.Types.GeomType) input.ReadEnum();
                break;
              }
              case 34:
              case 32: {
                geometry_.AddEntriesFrom(input, _repeated_geometry_codec);
                break;
              }
            }
          }
        }

      }

      public sealed partial class Layer : pb::IMessage<Layer> {
        private static readonly pb::MessageParser<Layer> _parser = new pb::MessageParser<Layer>(() => new Layer());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Layer> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Example.Tile.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Layer() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Layer(Layer other) : this() {
          version_ = other.version_;
          name_ = other.name_;
          features_ = other.features_.Clone();
          keys_ = other.keys_.Clone();
          values_ = other.values_.Clone();
          extent_ = other.extent_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Layer Clone() {
          return new Layer(this);
        }

        /// <summary>Field number for the "version" field.</summary>
        public const int VersionFieldNumber = 15;
        private uint version_;
        /// <summary>
        /// Any compliant implementation must first read the version
        /// number encoded in this message and choose the correct
        /// implementation for this version number before proceeding to
        /// decode other parts of this message.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Version {
          get { return version_; }
          set {
            version_ = value;
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "features" field.</summary>
        public const int FeaturesFieldNumber = 2;
        private static readonly pb::FieldCodec<global::Example.Tile.Types.Feature> _repeated_features_codec
            = pb::FieldCodec.ForMessage(18, global::Example.Tile.Types.Feature.Parser);
        private readonly pbc::RepeatedField<global::Example.Tile.Types.Feature> features_ = new pbc::RepeatedField<global::Example.Tile.Types.Feature>();
        /// <summary>
        /// The actual features in this tile.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Example.Tile.Types.Feature> Features {
          get { return features_; }
        }

        /// <summary>Field number for the "keys" field.</summary>
        public const int KeysFieldNumber = 3;
        private static readonly pb::FieldCodec<string> _repeated_keys_codec
            = pb::FieldCodec.ForString(26);
        private readonly pbc::RepeatedField<string> keys_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// Dictionary encoding for keys
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> Keys {
          get { return keys_; }
        }

        /// <summary>Field number for the "values" field.</summary>
        public const int ValuesFieldNumber = 4;
        private static readonly pb::FieldCodec<global::Example.Tile.Types.Value> _repeated_values_codec
            = pb::FieldCodec.ForMessage(34, global::Example.Tile.Types.Value.Parser);
        private readonly pbc::RepeatedField<global::Example.Tile.Types.Value> values_ = new pbc::RepeatedField<global::Example.Tile.Types.Value>();
        /// <summary>
        /// Dictionary encoding for values
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Example.Tile.Types.Value> Values {
          get { return values_; }
        }

        /// <summary>Field number for the "extent" field.</summary>
        public const int ExtentFieldNumber = 5;
        private uint extent_;
        /// <summary>
        /// The bounding box in this tile spans from 0..4095 units
        /// Although this is an "optional" field it is required by the specification.
        /// See https://github.com/mapbox/vector-tile-spec/issues/47
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Extent {
          get { return extent_; }
          set {
            extent_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Layer);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Layer other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Version != other.Version) return false;
          if (Name != other.Name) return false;
          if(!features_.Equals(other.features_)) return false;
          if(!keys_.Equals(other.keys_)) return false;
          if(!values_.Equals(other.values_)) return false;
          if (Extent != other.Extent) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Version != 0) hash ^= Version.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          hash ^= features_.GetHashCode();
          hash ^= keys_.GetHashCode();
          hash ^= values_.GetHashCode();
          if (Extent != 0) hash ^= Extent.GetHashCode();
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
          if (Name.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Name);
          }
          features_.WriteTo(output, _repeated_features_codec);
          keys_.WriteTo(output, _repeated_keys_codec);
          values_.WriteTo(output, _repeated_values_codec);
          if (Extent != 0) {
            output.WriteRawTag(40);
            output.WriteUInt32(Extent);
          }
          if (Version != 0) {
            output.WriteRawTag(120);
            output.WriteUInt32(Version);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Version != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          size += features_.CalculateSize(_repeated_features_codec);
          size += keys_.CalculateSize(_repeated_keys_codec);
          size += values_.CalculateSize(_repeated_values_codec);
          if (Extent != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Extent);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Layer other) {
          if (other == null) {
            return;
          }
          if (other.Version != 0) {
            Version = other.Version;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          features_.Add(other.features_);
          keys_.Add(other.keys_);
          values_.Add(other.values_);
          if (other.Extent != 0) {
            Extent = other.Extent;
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
                Name = input.ReadString();
                break;
              }
              case 18: {
                features_.AddEntriesFrom(input, _repeated_features_codec);
                break;
              }
              case 26: {
                keys_.AddEntriesFrom(input, _repeated_keys_codec);
                break;
              }
              case 34: {
                values_.AddEntriesFrom(input, _repeated_values_codec);
                break;
              }
              case 40: {
                Extent = input.ReadUInt32();
                break;
              }
              case 120: {
                Version = input.ReadUInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
