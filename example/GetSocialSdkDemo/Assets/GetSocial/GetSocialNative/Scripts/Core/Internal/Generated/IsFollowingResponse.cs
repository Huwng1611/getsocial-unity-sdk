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
public partial class IsFollowingResponse : TBase
{
  private Dictionary<string, bool> _result;

  public Dictionary<string, bool> Result
  {
    get
    {
      return _result;
    }
    set
    {
      __isset.result = true;
      this._result = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool result;
  }

  public IsFollowingResponse() {
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
            if (field.Type == TType.Map) {
              {
                Result = new Dictionary<string, bool>();
                TMap _map45 = iprot.ReadMapBegin();
                for( int _i46 = 0; _i46 < _map45.Count; ++_i46)
                {
                  string _key47;
                  bool _val48;
                  _key47 = iprot.ReadString();
                  _val48 = iprot.ReadBool();
                  Result[_key47] = _val48;
                }
                iprot.ReadMapEnd();
              }
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
      TStruct struc = new TStruct("IsFollowingResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Result != null && __isset.result) {
        field.Name = "result";
        field.Type = TType.Map;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.Bool, Result.Count));
          foreach (string _iter49 in Result.Keys)
          {
            oprot.WriteString(_iter49);
            oprot.WriteBool(Result[_iter49]);
          }
          oprot.WriteMapEnd();
        }
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
    StringBuilder __sb = new StringBuilder("IsFollowingResponse(");
    bool __first = true;
    if (Result != null && __isset.result) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Result: ");
      __sb.Append(Result);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif