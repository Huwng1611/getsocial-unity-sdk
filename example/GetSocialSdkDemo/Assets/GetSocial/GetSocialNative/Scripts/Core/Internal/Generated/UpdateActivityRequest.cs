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
  /// #sdk7
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class UpdateActivityRequest : TBase
  {
    private string _sessionId;
    private Dictionary<string, AFContent> _content;
    private Dictionary<string, string> _properties;
    private string _activityId;

    public string SessionId
    {
      get
      {
        return _sessionId;
      }
      set
      {
        __isset.sessionId = true;
        this._sessionId = value;
      }
    }

    public Dictionary<string, AFContent> Content
    {
      get
      {
        return _content;
      }
      set
      {
        __isset.content = true;
        this._content = value;
      }
    }

    public Dictionary<string, string> Properties
    {
      get
      {
        return _properties;
      }
      set
      {
        __isset.properties = true;
        this._properties = value;
      }
    }

    public string ActivityId
    {
      get
      {
        return _activityId;
      }
      set
      {
        __isset.activityId = true;
        this._activityId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sessionId;
      public bool content;
      public bool properties;
      public bool activityId;
    }

    public UpdateActivityRequest() {
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
              if (field.Type == TType.String) {
                SessionId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Map) {
                {
                  Content = new Dictionary<string, AFContent>();
                  TMap _map154 = iprot.ReadMapBegin();
                  for( int _i155 = 0; _i155 < _map154.Count; ++_i155)
                  {
                    string _key156;
                    AFContent _val157;
                    _key156 = iprot.ReadString();
                    _val157 = new AFContent();
                    _val157.Read(iprot);
                    Content[_key156] = _val157;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Map) {
                {
                  Properties = new Dictionary<string, string>();
                  TMap _map158 = iprot.ReadMapBegin();
                  for( int _i159 = 0; _i159 < _map158.Count; ++_i159)
                  {
                    string _key160;
                    string _val161;
                    _key160 = iprot.ReadString();
                    _val161 = iprot.ReadString();
                    Properties[_key160] = _val161;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                ActivityId = iprot.ReadString();
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
        TStruct struc = new TStruct("UpdateActivityRequest");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (SessionId != null && __isset.sessionId) {
          field.Name = "sessionId";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(SessionId);
          oprot.WriteFieldEnd();
        }
        if (Content != null && __isset.content) {
          field.Name = "content";
          field.Type = TType.Map;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Content.Count));
            foreach (string _iter162 in Content.Keys)
            {
              oprot.WriteString(_iter162);
              Content[_iter162].Write(oprot);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Properties != null && __isset.properties) {
          field.Name = "properties";
          field.Type = TType.Map;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, Properties.Count));
            foreach (string _iter163 in Properties.Keys)
            {
              oprot.WriteString(_iter163);
              oprot.WriteString(Properties[_iter163]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (ActivityId != null && __isset.activityId) {
          field.Name = "activityId";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ActivityId);
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
      StringBuilder __sb = new StringBuilder("UpdateActivityRequest(");
      bool __first = true;
      if (SessionId != null && __isset.sessionId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SessionId: ");
        __sb.Append(SessionId);
      }
      if (Content != null && __isset.content) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Content: ");
        __sb.Append(Content.ToDebugString());
      }
      if (Properties != null && __isset.properties) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Properties: ");
        __sb.Append(Properties.ToDebugString());
      }
      if (ActivityId != null && __isset.activityId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ActivityId: ");
        __sb.Append(ActivityId);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif
