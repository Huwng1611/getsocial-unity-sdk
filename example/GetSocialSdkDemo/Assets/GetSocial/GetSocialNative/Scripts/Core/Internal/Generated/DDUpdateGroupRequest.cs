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
  /// update
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class DDUpdateGroupRequest : TBase
  {
    private string _sessionId;
    private string _appId;
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

    public string AppId
    {
      get
      {
        return _appId;
      }
      set
      {
        __isset.appId = true;
        this._appId = value;
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
      public bool appId;
      public bool id;
      public bool title;
      public bool groupDescription;
      public bool avatarUrl;
      public bool permissions;
      public bool properties;
      public bool isDiscoverable;
      public bool isPrivate;
    }

    public DDUpdateGroupRequest() {
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
                AppId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Map) {
                {
                  Title = new Dictionary<string, string>();
                  TMap _map103 = iprot.ReadMapBegin();
                  for( int _i104 = 0; _i104 < _map103.Count; ++_i104)
                  {
                    string _key105;
                    string _val106;
                    _key105 = iprot.ReadString();
                    _val106 = iprot.ReadString();
                    Title[_key105] = _val106;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Map) {
                {
                  GroupDescription = new Dictionary<string, string>();
                  TMap _map107 = iprot.ReadMapBegin();
                  for( int _i108 = 0; _i108 < _map107.Count; ++_i108)
                  {
                    string _key109;
                    string _val110;
                    _key109 = iprot.ReadString();
                    _val110 = iprot.ReadString();
                    GroupDescription[_key109] = _val110;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                AvatarUrl = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Map) {
                {
                  Permissions = new Dictionary<int, int>();
                  TMap _map111 = iprot.ReadMapBegin();
                  for( int _i112 = 0; _i112 < _map111.Count; ++_i112)
                  {
                    int _key113;
                    int _val114;
                    _key113 = iprot.ReadI32();
                    _val114 = iprot.ReadI32();
                    Permissions[_key113] = _val114;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Map) {
                {
                  Properties = new Dictionary<string, string>();
                  TMap _map115 = iprot.ReadMapBegin();
                  for( int _i116 = 0; _i116 < _map115.Count; ++_i116)
                  {
                    string _key117;
                    string _val118;
                    _key117 = iprot.ReadString();
                    _val118 = iprot.ReadString();
                    Properties[_key117] = _val118;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Bool) {
                IsDiscoverable = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
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
        TStruct struc = new TStruct("DDUpdateGroupRequest");
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
        if (AppId != null && __isset.appId) {
          field.Name = "appId";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(AppId);
          oprot.WriteFieldEnd();
        }
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (Title != null && __isset.title) {
          field.Name = "title";
          field.Type = TType.Map;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, Title.Count));
            foreach (string _iter119 in Title.Keys)
            {
              oprot.WriteString(_iter119);
              oprot.WriteString(Title[_iter119]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (GroupDescription != null && __isset.groupDescription) {
          field.Name = "groupDescription";
          field.Type = TType.Map;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, GroupDescription.Count));
            foreach (string _iter120 in GroupDescription.Keys)
            {
              oprot.WriteString(_iter120);
              oprot.WriteString(GroupDescription[_iter120]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (AvatarUrl != null && __isset.avatarUrl) {
          field.Name = "avatarUrl";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(AvatarUrl);
          oprot.WriteFieldEnd();
        }
        if (Permissions != null && __isset.permissions) {
          field.Name = "permissions";
          field.Type = TType.Map;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.I32, TType.I32, Permissions.Count));
            foreach (int _iter121 in Permissions.Keys)
            {
              oprot.WriteI32(_iter121);
              oprot.WriteI32(Permissions[_iter121]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Properties != null && __isset.properties) {
          field.Name = "properties";
          field.Type = TType.Map;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.String, TType.String, Properties.Count));
            foreach (string _iter122 in Properties.Keys)
            {
              oprot.WriteString(_iter122);
              oprot.WriteString(Properties[_iter122]);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.isDiscoverable) {
          field.Name = "isDiscoverable";
          field.Type = TType.Bool;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsDiscoverable);
          oprot.WriteFieldEnd();
        }
        if (__isset.isPrivate) {
          field.Name = "isPrivate";
          field.Type = TType.Bool;
          field.ID = 10;
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
      StringBuilder __sb = new StringBuilder("DDUpdateGroupRequest(");
      bool __first = true;
      if (SessionId != null && __isset.sessionId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SessionId: ");
        __sb.Append(SessionId);
      }
      if (AppId != null && __isset.appId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AppId: ");
        __sb.Append(AppId);
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
