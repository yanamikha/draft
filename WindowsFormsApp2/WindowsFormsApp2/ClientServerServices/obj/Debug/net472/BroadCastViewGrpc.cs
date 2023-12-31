// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/BroadCastView.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BroadCastView {
  public static partial class BroadCastService
  {
    static readonly string __ServiceName = "BroadCastView.BroadCastService";

    static readonly grpc::Marshaller<global::Authenticity.Token> __Marshaller_authenticity_Token = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Authenticity.Token.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BroadCastView.OptionalMessage> __Marshaller_BroadCastView_OptionalMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BroadCastView.OptionalMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BroadCastView.Message> __Marshaller_BroadCastView_Message = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BroadCastView.Message.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Authenticity.Token, global::BroadCastView.OptionalMessage> __Method_SubscribeMessageStream = new grpc::Method<global::Authenticity.Token, global::BroadCastView.OptionalMessage>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SubscribeMessageStream",
        __Marshaller_authenticity_Token,
        __Marshaller_BroadCastView_OptionalMessage);

    static readonly grpc::Method<global::BroadCastView.Message, global::Google.Protobuf.WellKnownTypes.Empty> __Method_PostMessage = new grpc::Method<global::BroadCastView.Message, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PostMessage",
        __Marshaller_BroadCastView_Message,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BroadCastView.BroadCastViewReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BroadCastService</summary>
    [grpc::BindServiceMethod(typeof(BroadCastService), "BindService")]
    public abstract partial class BroadCastServiceBase
    {
      public virtual global::System.Threading.Tasks.Task SubscribeMessageStream(global::Authenticity.Token request, grpc::IServerStreamWriter<global::BroadCastView.OptionalMessage> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> PostMessage(global::BroadCastView.Message request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BroadCastService</summary>
    public partial class BroadCastServiceClient : grpc::ClientBase<BroadCastServiceClient>
    {
      /// <summary>Creates a new client for BroadCastService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BroadCastServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BroadCastService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BroadCastServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BroadCastServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BroadCastServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::BroadCastView.OptionalMessage> SubscribeMessageStream(global::Authenticity.Token request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubscribeMessageStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::BroadCastView.OptionalMessage> SubscribeMessageStream(global::Authenticity.Token request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_SubscribeMessageStream, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty PostMessage(global::BroadCastView.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PostMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty PostMessage(global::BroadCastView.Message request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PostMessage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PostMessageAsync(global::BroadCastView.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PostMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PostMessageAsync(global::BroadCastView.Message request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PostMessage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BroadCastServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BroadCastServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BroadCastServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SubscribeMessageStream, serviceImpl.SubscribeMessageStream)
          .AddMethod(__Method_PostMessage, serviceImpl.PostMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BroadCastServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SubscribeMessageStream, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Authenticity.Token, global::BroadCastView.OptionalMessage>(serviceImpl.SubscribeMessageStream));
      serviceBinder.AddMethod(__Method_PostMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BroadCastView.Message, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.PostMessage));
    }

  }
}
#endregion
