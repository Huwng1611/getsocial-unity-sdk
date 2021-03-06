#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR
/**
 * Autogenerated by Thrift Compiler ()
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace GetSocialSdk.Core 
{

  /// <summary>
  /// options: [-]status
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class DDGetAnnouncementsResponse : TBase
  {
    private List<AFAnnouncement> _data;
    private List<AFEntityReference> _entityDetails;
    private string _nextCursor;

    public List<AFAnnouncement> Data
    {
      get
      {
        return _data;
      }
      set
      {
        __isset.data = true;
        this._data = value;
      }
    }

    public List<AFEntityReference> EntityDetails
    {
      get
      {
        return _entityDetails;
      }
      set
      {
        __isset.entityDetails = true;
        this._entityDetails = value;
      }
    }

    public string NextCursor
    {
      get
      {
        return _nextCursor;
      }
      set
      {
        __isset.nextCursor = true;
        this._nextCursor = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool data;
      public bool entityDetails;
      public bool nextCursor;
    }

    public DDGetAnnouncementsResponse() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.List) {
                {
                  Data = new List<AFAnnouncement>();
                  TList _list126 = iprot.ReadListBegin();
                  for( int _i127 = 0; _i127 < _list126.Count; ++_i127)
                  {
                    AFAnnouncement _elem128;
                    _elem128 = new AFAnnouncement();
                    _elem128.Read(iprot);
                    Data.Add(_elem128);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  EntityDetails = new List<AFEntityReference>();
                  TList _list129 = iprot.ReadListBegin();
                  for( int _i130 = 0; _i130 < _list129.Count; ++_i130)
                  {
                    AFEntityReference _elem131;
                    _elem131 = new AFEntityReference();
                    _elem131.Read(iprot);
                    EntityDetails.Add(_elem131);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                NextCursor = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("DDGetAnnouncementsResponse");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Data != null && __isset.data) {
          field.Name = "data";
          field.Type = TType.List;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Data.Count));
            foreach (AFAnnouncement _iter132 in Data)
            {
              _iter132.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (EntityDetails != null && __isset.entityDetails) {
          field.Name = "entityDetails";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, EntityDetails.Count));
            foreach (AFEntityReference _iter133 in EntityDetails)
            {
              _iter133.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (NextCursor != null && __isset.nextCursor) {
          field.Name = "nextCursor";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NextCursor);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("DDGetAnnouncementsResponse(");
      bool __first = true;
      if (Data != null && __isset.data) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Data: ");
        __sb.Append(Data.ToDebugString());
      }
      if (EntityDetails != null && __isset.entityDetails) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("EntityDetails: ");
        __sb.Append(EntityDetails.ToDebugString());
      }
      if (NextCursor != null && __isset.nextCursor) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NextCursor: ");
        __sb.Append(NextCursor);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif
