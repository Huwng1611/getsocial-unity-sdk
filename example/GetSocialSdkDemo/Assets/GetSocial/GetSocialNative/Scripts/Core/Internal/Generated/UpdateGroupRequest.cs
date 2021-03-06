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
  public partial class UpdateGroupRequest : TBase
  {
    private string _sessionId;
    private string _id;
    private Dictionary<string, string> _title;
    private Dictionary<string, string> _groupDescription;
    private string _avatarUrl;
    private Dictionary<int, int> _permissions;
    private Dictionary<string, string> _properties;
    private bool _isDiscoverable;
    private bool _isPrivate;

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

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public Dictionary<string, string> Title
    {
      get
      {
        return _title;
      }
      set
      {
        __isset.title = true;
        this._title = value;
      }
    }

    public Dictionary<string, string> GroupDescription
    {
      get
      {
        return _groupDescription;
      }
      set
      {
        __isset.groupDescription = true;
        this._groupDescription = value;
      }
    }

    public string AvatarUrl
    {
      get
      {
        return _avatarUrl;
      }
      set
      {
        __isset.avatarUrl = true;
        this._avatarUrl = value;
      }
    }

    /// <summary>
    /// map<SGAction, SGRole> permissions, check SGAction and SGRole for possible values
    /// </summary>
    public Dictionary<int, int> Permissions
    {
      get
      {
        return _permissions;
      }
      set
      {
        __isset.permissions = true;
        this._permissions = value;
      }
    }

    /// <summary>
    /// feed.post = admin, feed.post.interact = everyone
    /// </summary>
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

    public bool IsDiscoverable
    {
      get
      {
        return _isDiscoverable;
      }
      set
      {
        __isset.isDiscoverable = true;
        this._isDiscoverable = value;
      }
    }

    public bool IsPrivate
    {
      get
      {
        return _isPrivate;
      }
      set
      {
        __isset.isPrivate = true;
        this._isPrivate = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sessionId;
      public bool id;
      public bool title;
      public bool groupDescription;
      public bool avatarUrl;
      public bool permissions;
      public bool properties;
      public bool isDiscoverable;
      public bool isPrivate;
    }

    public UpdateGroupRequest() {
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
              if (field.Type == TType.String) {
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Map) {
                {
                  Title = new Dictionary<string, string>();
                  TMap _map30 = iprot.ReadMapBegin();
                  for( int _i31 = 0; _i31 < _map30.Count; ++_i31)
                  {
                    string _key32;
                    string _val33;
                    _key32 = iprot.ReadString();
                    _val33 = iprot.ReadString();
                    Title[_key32] = _val33;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Map) {
                {
                  GroupDescription = new Dictionary<string, string>();
                  TMap _map34 = iprot.ReadMapBegin();
                  for( int _i35 = 0; _i35 < _map34.Count; ++_i35)
                  {
                    string _key36;
                    string _val37;
                    _key36 = iprot.ReadString();
                    _val37 = iprot.ReadString();
                    GroupDescription[_key36] = _val37;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                AvatarUrl = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Map) {
                {
                  Permissions = new Dictionary<int, int>();
                  TMap _map38 = iprot.ReadMapBegin();
                  for( int _i39 = 0; _i39 < _map38.Count; ++_i39)
                  {
                    int _key40;
                    int _val41;
                    _key40 = iprot.ReadI32();
                    _val41 = iprot.ReadI32();
                    Permissions[_key40] = _val41;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Map) {
                {
                  Properties = new Dictionary<string, string>();
                  TMap _map42 = iprot.ReadMapBegin();
                  for( int _i43 = 0; _i43 < _map42.Count; ++_i43)
                  {
                    string _key44;
                    string _val45;
                    _key44 = iprot.ReadString();
                    _val45 = iprot.ReadString();
                    Properties[_key44] = _val45;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Bool) {
                IsDiscoverable = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Bool) {
                IsPrivate = iprot.ReadBool();
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
        TStruct struc = new TStruct("UpdateGroupRequest");
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
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (Title != null && __isset.title) {
          field.Name = "title";
          field.Type = TType.Map;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, Title.Count));
            foreach (string _iter46 in Title.Keys)
            {
              oprot.WriteString(_iter46);
              oprot.WriteString(Title[_iter46]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (GroupDescription != null && __isset.groupDescription) {
          field.Name = "groupDescription";
          field.Type = TType.Map;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, GroupDescription.Count));
            foreach (string _iter47 in GroupDescription.Keys)
            {
              oprot.WriteString(_iter47);
              oprot.WriteString(GroupDescription[_iter47]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (AvatarUrl != null && __isset.avatarUrl) {
          field.Name = "avatarUrl";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(AvatarUrl);
          oprot.WriteFieldEnd();
        }
        if (Permissions != null && __isset.permissions) {
          field.Name = "permissions";
          field.Type = TType.Map;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.I32, TType.I32, Permissions.Count));
            foreach (int _iter48 in Permissions.Keys)
            {
              oprot.WriteI32(_iter48);
              oprot.WriteI32(Permissions[_iter48]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Properties != null && __isset.properties) {
          field.Name = "properties";
          field.Type = TType.Map;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, Properties.Count));
            foreach (string _iter49 in Properties.Keys)
            {
              oprot.WriteString(_iter49);
              oprot.WriteString(Properties[_iter49]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.isDiscoverable) {
          field.Name = "isDiscoverable";
          field.Type = TType.Bool;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsDiscoverable);
          oprot.WriteFieldEnd();
        }
        if (__isset.isPrivate) {
          field.Name = "isPrivate";
          field.Type = TType.Bool;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsPrivate);
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
      StringBuilder __sb = new StringBuilder("UpdateGroupRequest(");
      bool __first = true;
      if (SessionId != null && __isset.sessionId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SessionId: ");
        __sb.Append(SessionId);
      }
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Title != null && __isset.title) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Title: ");
        __sb.Append(Title.ToDebugString());
      }
      if (GroupDescription != null && __isset.groupDescription) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("GroupDescription: ");
        __sb.Append(GroupDescription.ToDebugString());
      }
      if (AvatarUrl != null && __isset.avatarUrl) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AvatarUrl: ");
        __sb.Append(AvatarUrl);
      }
      if (Permissions != null && __isset.permissions) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Permissions: ");
        __sb.Append(Permissions.ToDebugString());
      }
      if (Properties != null && __isset.properties) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Properties: ");
        __sb.Append(Properties.ToDebugString());
      }
      if (__isset.isDiscoverable) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsDiscoverable: ");
        __sb.Append(IsDiscoverable);
      }
      if (__isset.isPrivate) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsPrivate: ");
        __sb.Append(IsPrivate);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif
