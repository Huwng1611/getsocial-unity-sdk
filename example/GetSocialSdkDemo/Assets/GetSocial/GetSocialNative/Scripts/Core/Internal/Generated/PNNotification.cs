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
  public partial class PNNotification : TBase
  {
    private string _id;
    private THNotificationTemplateMedia _media;
    private int _createdAt;
    private string _text;
    private string _title;
    private THCreator _sender;
    private THAction _action;
    private string _type;
    private string _status;
    private List<THActionButton> _actionButtons;
    private int _expiration;

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

    public THNotificationTemplateMedia Media
    {
      get
      {
        return _media;
      }
      set
      {
        __isset.media = true;
        this._media = value;
      }
    }

    public int CreatedAt
    {
      get
      {
        return _createdAt;
      }
      set
      {
        __isset.createdAt = true;
        this._createdAt = value;
      }
    }

    public string Text
    {
      get
      {
        return _text;
      }
      set
      {
        __isset.text = true;
        this._text = value;
      }
    }

    public string Title
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

    public THCreator Sender
    {
      get
      {
        return _sender;
      }
      set
      {
        __isset.sender = true;
        this._sender = value;
      }
    }

    public THAction Action
    {
      get
      {
        return _action;
      }
      set
      {
        __isset.action = true;
        this._action = value;
      }
    }

    public string Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public string Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public List<THActionButton> ActionButtons
    {
      get
      {
        return _actionButtons;
      }
      set
      {
        __isset.actionButtons = true;
        this._actionButtons = value;
      }
    }

    public int Expiration
    {
      get
      {
        return _expiration;
      }
      set
      {
        __isset.expiration = true;
        this._expiration = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool media;
      public bool createdAt;
      public bool text;
      public bool title;
      public bool sender;
      public bool action;
      public bool type;
      public bool status;
      public bool actionButtons;
      public bool expiration;
    }

    public PNNotification() {
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
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Media = new THNotificationTemplateMedia();
                Media.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                CreatedAt = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                Text = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Title = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Struct) {
                Sender = new THCreator();
                Sender.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Struct) {
                Action = new THAction();
                Action.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.String) {
                Type = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.String) {
                Status = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.List) {
                {
                  ActionButtons = new List<THActionButton>();
                  TList _list120 = iprot.ReadListBegin();
                  for( int _i121 = 0; _i121 < _list120.Count; ++_i121)
                  {
                    THActionButton _elem122;
                    _elem122 = new THActionButton();
                    _elem122.Read(iprot);
                    ActionButtons.Add(_elem122);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.I32) {
                Expiration = iprot.ReadI32();
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
        TStruct struc = new TStruct("PNNotification");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (Media != null && __isset.media) {
          field.Name = "media";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Media.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.createdAt) {
          field.Name = "createdAt";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(CreatedAt);
          oprot.WriteFieldEnd();
        }
        if (Text != null && __isset.text) {
          field.Name = "text";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Text);
          oprot.WriteFieldEnd();
        }
        if (Title != null && __isset.title) {
          field.Name = "title";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Title);
          oprot.WriteFieldEnd();
        }
        if (Sender != null && __isset.sender) {
          field.Name = "sender";
          field.Type = TType.Struct;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          Sender.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Action != null && __isset.action) {
          field.Name = "action";
          field.Type = TType.Struct;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          Action.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Type != null && __isset.type) {
          field.Name = "type";
          field.Type = TType.String;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Type);
          oprot.WriteFieldEnd();
        }
        if (Status != null && __isset.status) {
          field.Name = "status";
          field.Type = TType.String;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Status);
          oprot.WriteFieldEnd();
        }
        if (ActionButtons != null && __isset.actionButtons) {
          field.Name = "actionButtons";
          field.Type = TType.List;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, ActionButtons.Count));
            foreach (THActionButton _iter123 in ActionButtons)
            {
              _iter123.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.expiration) {
          field.Name = "expiration";
          field.Type = TType.I32;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Expiration);
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
      StringBuilder __sb = new StringBuilder("PNNotification(");
      bool __first = true;
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Media != null && __isset.media) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Media: ");
        __sb.Append(Media== null ? "<null>" : Media.ToString());
      }
      if (__isset.createdAt) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CreatedAt: ");
        __sb.Append(CreatedAt);
      }
      if (Text != null && __isset.text) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Text: ");
        __sb.Append(Text);
      }
      if (Title != null && __isset.title) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Title: ");
        __sb.Append(Title);
      }
      if (Sender != null && __isset.sender) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Sender: ");
        __sb.Append(Sender== null ? "<null>" : Sender.ToString());
      }
      if (Action != null && __isset.action) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Action: ");
        __sb.Append(Action== null ? "<null>" : Action.ToString());
      }
      if (Type != null && __isset.type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type: ");
        __sb.Append(Type);
      }
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status);
      }
      if (ActionButtons != null && __isset.actionButtons) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ActionButtons: ");
        __sb.Append(ActionButtons.ToDebugString());
      }
      if (__isset.expiration) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Expiration: ");
        __sb.Append(Expiration);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif
