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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class THNotificationTemplateProperties : TBase
{
  private THPushNotificationOptions _pushNotificationOptions;
  private bool _saveToNotificationsCenter;

  /// <summary>
  /// 
  /// <seealso cref="THPushNotificationOptions"/>
  /// </summary>
  public THPushNotificationOptions PushNotificationOptions
  {
    get
    {
      return _pushNotificationOptions;
    }
    set
    {
      __isset.pushNotificationOptions = true;
      this._pushNotificationOptions = value;
    }
  }

  public bool SaveToNotificationsCenter
  {
    get
    {
      return _saveToNotificationsCenter;
    }
    set
    {
      __isset.saveToNotificationsCenter = true;
      this._saveToNotificationsCenter = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool pushNotificationOptions;
    public bool saveToNotificationsCenter;
  }

  public THNotificationTemplateProperties() {
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
            if (field.Type == TType.I32) {
              PushNotificationOptions = (THPushNotificationOptions)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              SaveToNotificationsCenter = iprot.ReadBool();
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
      TStruct struc = new TStruct("THNotificationTemplateProperties");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.pushNotificationOptions) {
        field.Name = "pushNotificationOptions";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)PushNotificationOptions);
        oprot.WriteFieldEnd();
      }
      if (__isset.saveToNotificationsCenter) {
        field.Name = "saveToNotificationsCenter";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(SaveToNotificationsCenter);
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
    StringBuilder __sb = new StringBuilder("THNotificationTemplateProperties(");
    bool __first = true;
    if (__isset.pushNotificationOptions) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("PushNotificationOptions: ");
      __sb.Append(PushNotificationOptions);
    }
    if (__isset.saveToNotificationsCenter) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("SaveToNotificationsCenter: ");
      __sb.Append(SaveToNotificationsCenter);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif