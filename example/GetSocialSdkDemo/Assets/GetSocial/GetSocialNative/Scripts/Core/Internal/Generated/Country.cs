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

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Country : TBase
  {
    private string _name;
    private string _pricePerEvent;
    private string _numberOfEvents;
    private string _totalPrice;

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string PricePerEvent
    {
      get
      {
        return _pricePerEvent;
      }
      set
      {
        __isset.pricePerEvent = true;
        this._pricePerEvent = value;
      }
    }

    /// <summary>
    /// e.g "$0,01"
    /// </summary>
    public string NumberOfEvents
    {
      get
      {
        return _numberOfEvents;
      }
      set
      {
        __isset.numberOfEvents = true;
        this._numberOfEvents = value;
      }
    }

    /// <summary>
    /// e.g "123"
    /// </summary>
    public string TotalPrice
    {
      get
      {
        return _totalPrice;
      }
      set
      {
        __isset.totalPrice = true;
        this._totalPrice = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool name;
      public bool pricePerEvent;
      public bool numberOfEvents;
      public bool totalPrice;
    }

    public Country() {
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
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                PricePerEvent = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                NumberOfEvents = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                TotalPrice = iprot.ReadString();
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
        TStruct struc = new TStruct("Country");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (PricePerEvent != null && __isset.pricePerEvent) {
          field.Name = "pricePerEvent";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(PricePerEvent);
          oprot.WriteFieldEnd();
        }
        if (NumberOfEvents != null && __isset.numberOfEvents) {
          field.Name = "numberOfEvents";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NumberOfEvents);
          oprot.WriteFieldEnd();
        }
        if (TotalPrice != null && __isset.totalPrice) {
          field.Name = "totalPrice";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(TotalPrice);
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
      StringBuilder __sb = new StringBuilder("Country(");
      bool __first = true;
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (PricePerEvent != null && __isset.pricePerEvent) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PricePerEvent: ");
        __sb.Append(PricePerEvent);
      }
      if (NumberOfEvents != null && __isset.numberOfEvents) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NumberOfEvents: ");
        __sb.Append(NumberOfEvents);
      }
      if (TotalPrice != null && __isset.totalPrice) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TotalPrice: ");
        __sb.Append(TotalPrice);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif