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
  /// #sdk6 #sdk7
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class THSdkAuthRequestAllInOne : TBase
  {
    private THSdkAuthRequest _sdkAuthRequest;
    private THProcessAppOpenRequest _processAppOpenRequest;

    public THSdkAuthRequest SdkAuthRequest
    {
      get
      {
        return _sdkAuthRequest;
      }
      set
      {
        __isset.sdkAuthRequest = true;
        this._sdkAuthRequest = value;
      }
    }

    public THProcessAppOpenRequest ProcessAppOpenRequest
    {
      get
      {
        return _processAppOpenRequest;
      }
      set
      {
        __isset.processAppOpenRequest = true;
        this._processAppOpenRequest = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sdkAuthRequest;
      public bool processAppOpenRequest;
    }

    public THSdkAuthRequestAllInOne() {
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
              if (field.Type == TType.Struct) {
                SdkAuthRequest = new THSdkAuthRequest();
                SdkAuthRequest.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                ProcessAppOpenRequest = new THProcessAppOpenRequest();
                ProcessAppOpenRequest.Read(iprot);
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
        TStruct struc = new TStruct("THSdkAuthRequestAllInOne");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (SdkAuthRequest != null && __isset.sdkAuthRequest) {
          field.Name = "sdkAuthRequest";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          SdkAuthRequest.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (ProcessAppOpenRequest != null && __isset.processAppOpenRequest) {
          field.Name = "processAppOpenRequest";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          ProcessAppOpenRequest.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("THSdkAuthRequestAllInOne(");
      bool __first = true;
      if (SdkAuthRequest != null && __isset.sdkAuthRequest) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SdkAuthRequest: ");
        __sb.Append(SdkAuthRequest);
      }
      if (ProcessAppOpenRequest != null && __isset.processAppOpenRequest) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProcessAppOpenRequest: ");
        __sb.Append(ProcessAppOpenRequest== null ? "<null>" : ProcessAppOpenRequest.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif
