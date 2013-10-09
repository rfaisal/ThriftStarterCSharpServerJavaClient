/**
 * Autogenerated by Thrift Compiler (0.9.0)
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

namespace Math
{
  public partial class MathService {
    public interface Iface {
      int add(int a, int b);
      #if SILVERLIGHT
      IAsyncResult Begin_add(AsyncCallback callback, object state, int a, int b);
      int End_add(IAsyncResult asyncResult);
      #endif
      int sub(int a, int b);
      #if SILVERLIGHT
      IAsyncResult Begin_sub(AsyncCallback callback, object state, int a, int b);
      int End_sub(IAsyncResult asyncResult);
      #endif
      int mul(int a, int b);
      #if SILVERLIGHT
      IAsyncResult Begin_mul(AsyncCallback callback, object state, int a, int b);
      int End_mul(IAsyncResult asyncResult);
      #endif
      int div(int a, int b);
      #if SILVERLIGHT
      IAsyncResult Begin_div(AsyncCallback callback, object state, int a, int b);
      int End_div(IAsyncResult asyncResult);
      #endif
      int mod(int a, int b);
      #if SILVERLIGHT
      IAsyncResult Begin_mod(AsyncCallback callback, object state, int a, int b);
      int End_mod(IAsyncResult asyncResult);
      #endif
    }

    public class Client : Iface {
      public Client(TProtocol prot) : this(prot, prot)
      {
      }

      public Client(TProtocol iprot, TProtocol oprot)
      {
        iprot_ = iprot;
        oprot_ = oprot;
      }

      protected TProtocol iprot_;
      protected TProtocol oprot_;
      protected int seqid_;

      public TProtocol InputProtocol
      {
        get { return iprot_; }
      }
      public TProtocol OutputProtocol
      {
        get { return oprot_; }
      }


      
      #if SILVERLIGHT
      public IAsyncResult Begin_add(AsyncCallback callback, object state, int a, int b)
      {
        return send_add(callback, state, a, b);
      }

      public int End_add(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_add();
      }

      #endif

      public int add(int a, int b)
      {
        #if !SILVERLIGHT
        send_add(a, b);
        return recv_add();

        #else
        var asyncResult = Begin_add(null, null, a, b);
        return End_add(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_add(AsyncCallback callback, object state, int a, int b)
      #else
      public void send_add(int a, int b)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("add", TMessageType.Call, seqid_));
        add_args args = new add_args();
        args.A = a;
        args.B = b;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_add()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        add_result result = new add_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "add failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_sub(AsyncCallback callback, object state, int a, int b)
      {
        return send_sub(callback, state, a, b);
      }

      public int End_sub(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_sub();
      }

      #endif

      public int sub(int a, int b)
      {
        #if !SILVERLIGHT
        send_sub(a, b);
        return recv_sub();

        #else
        var asyncResult = Begin_sub(null, null, a, b);
        return End_sub(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_sub(AsyncCallback callback, object state, int a, int b)
      #else
      public void send_sub(int a, int b)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("sub", TMessageType.Call, seqid_));
        sub_args args = new sub_args();
        args.A = a;
        args.B = b;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_sub()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        sub_result result = new sub_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "sub failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_mul(AsyncCallback callback, object state, int a, int b)
      {
        return send_mul(callback, state, a, b);
      }

      public int End_mul(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_mul();
      }

      #endif

      public int mul(int a, int b)
      {
        #if !SILVERLIGHT
        send_mul(a, b);
        return recv_mul();

        #else
        var asyncResult = Begin_mul(null, null, a, b);
        return End_mul(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_mul(AsyncCallback callback, object state, int a, int b)
      #else
      public void send_mul(int a, int b)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("mul", TMessageType.Call, seqid_));
        mul_args args = new mul_args();
        args.A = a;
        args.B = b;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_mul()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        mul_result result = new mul_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "mul failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_div(AsyncCallback callback, object state, int a, int b)
      {
        return send_div(callback, state, a, b);
      }

      public int End_div(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_div();
      }

      #endif

      public int div(int a, int b)
      {
        #if !SILVERLIGHT
        send_div(a, b);
        return recv_div();

        #else
        var asyncResult = Begin_div(null, null, a, b);
        return End_div(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_div(AsyncCallback callback, object state, int a, int b)
      #else
      public void send_div(int a, int b)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("div", TMessageType.Call, seqid_));
        div_args args = new div_args();
        args.A = a;
        args.B = b;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_div()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        div_result result = new div_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "div failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_mod(AsyncCallback callback, object state, int a, int b)
      {
        return send_mod(callback, state, a, b);
      }

      public int End_mod(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_mod();
      }

      #endif

      public int mod(int a, int b)
      {
        #if !SILVERLIGHT
        send_mod(a, b);
        return recv_mod();

        #else
        var asyncResult = Begin_mod(null, null, a, b);
        return End_mod(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_mod(AsyncCallback callback, object state, int a, int b)
      #else
      public void send_mod(int a, int b)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("mod", TMessageType.Call, seqid_));
        mod_args args = new mod_args();
        args.A = a;
        args.B = b;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_mod()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        mod_result result = new mod_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "mod failed: unknown result");
      }

    }
    public class Processor : TProcessor {
      public Processor(Iface iface)
      {
        iface_ = iface;
        processMap_["add"] = add_Process;
        processMap_["sub"] = sub_Process;
        processMap_["mul"] = mul_Process;
        processMap_["div"] = div_Process;
        processMap_["mod"] = mod_Process;
      }

      protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private Iface iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public bool Process(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public void add_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        add_args args = new add_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        add_result result = new add_result();
        result.Success = iface_.add(args.A, args.B);
        oprot.WriteMessageBegin(new TMessage("add", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void sub_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        sub_args args = new sub_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        sub_result result = new sub_result();
        result.Success = iface_.sub(args.A, args.B);
        oprot.WriteMessageBegin(new TMessage("sub", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void mul_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        mul_args args = new mul_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        mul_result result = new mul_result();
        result.Success = iface_.mul(args.A, args.B);
        oprot.WriteMessageBegin(new TMessage("mul", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void div_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        div_args args = new div_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        div_result result = new div_result();
        result.Success = iface_.div(args.A, args.B);
        oprot.WriteMessageBegin(new TMessage("div", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void mod_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        mod_args args = new mod_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        mod_result result = new mod_result();
        result.Success = iface_.mod(args.A, args.B);
        oprot.WriteMessageBegin(new TMessage("mod", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class add_args : TBase
    {
      private int _a;
      private int _b;

      public int A
      {
        get
        {
          return _a;
        }
        set
        {
          __isset.a = true;
          this._a = value;
        }
      }

      public int B
      {
        get
        {
          return _b;
        }
        set
        {
          __isset.b = true;
          this._b = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool a;
        public bool b;
      }

      public add_args() {
      }

      public void Read (TProtocol iprot)
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
                A = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                B = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("add_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.a) {
          field.Name = "a";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(A);
          oprot.WriteFieldEnd();
        }
        if (__isset.b) {
          field.Name = "b";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(B);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("add_args(");
        sb.Append("A: ");
        sb.Append(A);
        sb.Append(",B: ");
        sb.Append(B);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class add_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public add_result() {
      }

      public void Read (TProtocol iprot)
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
            case 0:
              if (field.Type == TType.I32) {
                Success = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("add_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I32;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("add_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class sub_args : TBase
    {
      private int _a;
      private int _b;

      public int A
      {
        get
        {
          return _a;
        }
        set
        {
          __isset.a = true;
          this._a = value;
        }
      }

      public int B
      {
        get
        {
          return _b;
        }
        set
        {
          __isset.b = true;
          this._b = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool a;
        public bool b;
      }

      public sub_args() {
      }

      public void Read (TProtocol iprot)
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
                A = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                B = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("sub_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.a) {
          field.Name = "a";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(A);
          oprot.WriteFieldEnd();
        }
        if (__isset.b) {
          field.Name = "b";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(B);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("sub_args(");
        sb.Append("A: ");
        sb.Append(A);
        sb.Append(",B: ");
        sb.Append(B);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class sub_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public sub_result() {
      }

      public void Read (TProtocol iprot)
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
            case 0:
              if (field.Type == TType.I32) {
                Success = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("sub_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I32;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("sub_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class mul_args : TBase
    {
      private int _a;
      private int _b;

      public int A
      {
        get
        {
          return _a;
        }
        set
        {
          __isset.a = true;
          this._a = value;
        }
      }

      public int B
      {
        get
        {
          return _b;
        }
        set
        {
          __isset.b = true;
          this._b = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool a;
        public bool b;
      }

      public mul_args() {
      }

      public void Read (TProtocol iprot)
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
                A = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                B = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("mul_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.a) {
          field.Name = "a";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(A);
          oprot.WriteFieldEnd();
        }
        if (__isset.b) {
          field.Name = "b";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(B);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("mul_args(");
        sb.Append("A: ");
        sb.Append(A);
        sb.Append(",B: ");
        sb.Append(B);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class mul_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public mul_result() {
      }

      public void Read (TProtocol iprot)
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
            case 0:
              if (field.Type == TType.I32) {
                Success = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("mul_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I32;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("mul_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class div_args : TBase
    {
      private int _a;
      private int _b;

      public int A
      {
        get
        {
          return _a;
        }
        set
        {
          __isset.a = true;
          this._a = value;
        }
      }

      public int B
      {
        get
        {
          return _b;
        }
        set
        {
          __isset.b = true;
          this._b = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool a;
        public bool b;
      }

      public div_args() {
      }

      public void Read (TProtocol iprot)
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
                A = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                B = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("div_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.a) {
          field.Name = "a";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(A);
          oprot.WriteFieldEnd();
        }
        if (__isset.b) {
          field.Name = "b";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(B);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("div_args(");
        sb.Append("A: ");
        sb.Append(A);
        sb.Append(",B: ");
        sb.Append(B);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class div_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public div_result() {
      }

      public void Read (TProtocol iprot)
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
            case 0:
              if (field.Type == TType.I32) {
                Success = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("div_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I32;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("div_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class mod_args : TBase
    {
      private int _a;
      private int _b;

      public int A
      {
        get
        {
          return _a;
        }
        set
        {
          __isset.a = true;
          this._a = value;
        }
      }

      public int B
      {
        get
        {
          return _b;
        }
        set
        {
          __isset.b = true;
          this._b = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool a;
        public bool b;
      }

      public mod_args() {
      }

      public void Read (TProtocol iprot)
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
                A = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                B = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("mod_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.a) {
          field.Name = "a";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(A);
          oprot.WriteFieldEnd();
        }
        if (__isset.b) {
          field.Name = "b";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(B);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("mod_args(");
        sb.Append("A: ");
        sb.Append(A);
        sb.Append(",B: ");
        sb.Append(B);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class mod_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public mod_result() {
      }

      public void Read (TProtocol iprot)
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
            case 0:
              if (field.Type == TType.I32) {
                Success = iprot.ReadI32();
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

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("mod_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I32;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("mod_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }

  }
}