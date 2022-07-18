// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantProfile.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class ApplicantProfileService
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.ApplicantProfileService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.IdRequest3> __Marshaller_CareerCloud_gRPC_IdRequest3 = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.IdRequest3.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.ApplicantProfile> __Marshaller_CareerCloud_gRPC_ApplicantProfile = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.ApplicantProfile.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.ApplicantProfiles> __Marshaller_CareerCloud_gRPC_ApplicantProfiles = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CareerCloud.gRPC.Protos.ApplicantProfiles.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.IdRequest3, global::CareerCloud.gRPC.Protos.ApplicantProfile> __Method_GetApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.IdRequest3, global::CareerCloud.gRPC.Protos.ApplicantProfile>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetApplicantProfile",
        __Marshaller_CareerCloud_gRPC_IdRequest3,
        __Marshaller_CareerCloud_gRPC_ApplicantProfile);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.ApplicantProfiles> __Method_GetApplicantProfiles = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.ApplicantProfiles>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetApplicantProfiles",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_CareerCloud_gRPC_ApplicantProfiles);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfiles,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfiles,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteApplicantProfile = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteApplicantProfile",
        __Marshaller_CareerCloud_gRPC_ApplicantProfiles,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.ApplicantProfileReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ApplicantProfileService</summary>
    [grpc::BindServiceMethod(typeof(ApplicantProfileService), "BindService")]
    public abstract partial class ApplicantProfileServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.ApplicantProfile> GetApplicantProfile(global::CareerCloud.gRPC.Protos.IdRequest3 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.ApplicantProfiles> GetApplicantProfiles(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfiles request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfiles request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteApplicantProfile(global::CareerCloud.gRPC.Protos.ApplicantProfiles request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ApplicantProfileServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetApplicantProfile, serviceImpl.GetApplicantProfile)
          .AddMethod(__Method_GetApplicantProfiles, serviceImpl.GetApplicantProfiles)
          .AddMethod(__Method_AddApplicantProfile, serviceImpl.AddApplicantProfile)
          .AddMethod(__Method_UpdateApplicantProfile, serviceImpl.UpdateApplicantProfile)
          .AddMethod(__Method_DeleteApplicantProfile, serviceImpl.DeleteApplicantProfile).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ApplicantProfileServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.IdRequest3, global::CareerCloud.gRPC.Protos.ApplicantProfile>(serviceImpl.GetApplicantProfile));
      serviceBinder.AddMethod(__Method_GetApplicantProfiles, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CareerCloud.gRPC.Protos.ApplicantProfiles>(serviceImpl.GetApplicantProfiles));
      serviceBinder.AddMethod(__Method_AddApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.AddApplicantProfile));
      serviceBinder.AddMethod(__Method_UpdateApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateApplicantProfile));
      serviceBinder.AddMethod(__Method_DeleteApplicantProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantProfiles, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteApplicantProfile));
    }

  }
}
#endregion