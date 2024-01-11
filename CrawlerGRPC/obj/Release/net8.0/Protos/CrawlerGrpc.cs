// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/crawler.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CrawlerGRPC {
  public static partial class Crawler
  {
    static readonly string __ServiceName = "crawler.Crawler";

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
    static readonly grpc::Marshaller<global::CrawlerGRPC.StartRequest> __Marshaller_crawler_StartRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.StartRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.StartResponse> __Marshaller_crawler_StartResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.StartResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.StopRequest> __Marshaller_crawler_StopRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.StopRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.StopResponse> __Marshaller_crawler_StopResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.StopResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.CrawlRequest> __Marshaller_crawler_CrawlRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.CrawlRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.CrawlResponse> __Marshaller_crawler_CrawlResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.CrawlResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.DeleteRequest> __Marshaller_crawler_DeleteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.DeleteRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.DeleteResponse> __Marshaller_crawler_DeleteResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.DeleteResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.StatusRequest> __Marshaller_crawler_StatusRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.StatusRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.StatusResponse> __Marshaller_crawler_StatusResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.StatusResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.CategoriesRequest> __Marshaller_crawler_CategoriesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.CategoriesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.CategoriesResponse> __Marshaller_crawler_CategoriesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.CategoriesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.ArticleRequest> __Marshaller_crawler_ArticleRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.ArticleRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.ArticleResponse> __Marshaller_crawler_ArticleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.ArticleResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.ArticlesRequest> __Marshaller_crawler_ArticlesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.ArticlesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPC.ArticlesResponse> __Marshaller_crawler_ArticlesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPC.ArticlesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.StartRequest, global::CrawlerGRPC.StartResponse> __Method_Start = new grpc::Method<global::CrawlerGRPC.StartRequest, global::CrawlerGRPC.StartResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Start",
        __Marshaller_crawler_StartRequest,
        __Marshaller_crawler_StartResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.StopRequest, global::CrawlerGRPC.StopResponse> __Method_Stop = new grpc::Method<global::CrawlerGRPC.StopRequest, global::CrawlerGRPC.StopResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Stop",
        __Marshaller_crawler_StopRequest,
        __Marshaller_crawler_StopResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.CrawlRequest, global::CrawlerGRPC.CrawlResponse> __Method_Crawl = new grpc::Method<global::CrawlerGRPC.CrawlRequest, global::CrawlerGRPC.CrawlResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Crawl",
        __Marshaller_crawler_CrawlRequest,
        __Marshaller_crawler_CrawlResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.DeleteRequest, global::CrawlerGRPC.DeleteResponse> __Method_Delete = new grpc::Method<global::CrawlerGRPC.DeleteRequest, global::CrawlerGRPC.DeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_crawler_DeleteRequest,
        __Marshaller_crawler_DeleteResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.StatusRequest, global::CrawlerGRPC.StatusResponse> __Method_Status = new grpc::Method<global::CrawlerGRPC.StatusRequest, global::CrawlerGRPC.StatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Status",
        __Marshaller_crawler_StatusRequest,
        __Marshaller_crawler_StatusResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.CategoriesRequest, global::CrawlerGRPC.CategoriesResponse> __Method_GetCategories = new grpc::Method<global::CrawlerGRPC.CategoriesRequest, global::CrawlerGRPC.CategoriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategories",
        __Marshaller_crawler_CategoriesRequest,
        __Marshaller_crawler_CategoriesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.ArticleRequest, global::CrawlerGRPC.ArticleResponse> __Method_GetArticle = new grpc::Method<global::CrawlerGRPC.ArticleRequest, global::CrawlerGRPC.ArticleResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetArticle",
        __Marshaller_crawler_ArticleRequest,
        __Marshaller_crawler_ArticleResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPC.ArticlesRequest, global::CrawlerGRPC.ArticlesResponse> __Method_GetArticles = new grpc::Method<global::CrawlerGRPC.ArticlesRequest, global::CrawlerGRPC.ArticlesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetArticles",
        __Marshaller_crawler_ArticlesRequest,
        __Marshaller_crawler_ArticlesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CrawlerGRPC.CrawlerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Crawler</summary>
    [grpc::BindServiceMethod(typeof(Crawler), "BindService")]
    public abstract partial class CrawlerBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.StartResponse> Start(global::CrawlerGRPC.StartRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.StopResponse> Stop(global::CrawlerGRPC.StopRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.CrawlResponse> Crawl(global::CrawlerGRPC.CrawlRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.DeleteResponse> Delete(global::CrawlerGRPC.DeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.StatusResponse> Status(global::CrawlerGRPC.StatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.CategoriesResponse> GetCategories(global::CrawlerGRPC.CategoriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.ArticleResponse> GetArticle(global::CrawlerGRPC.ArticleRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CrawlerGRPC.ArticlesResponse> GetArticles(global::CrawlerGRPC.ArticlesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CrawlerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Start, serviceImpl.Start)
          .AddMethod(__Method_Stop, serviceImpl.Stop)
          .AddMethod(__Method_Crawl, serviceImpl.Crawl)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_Status, serviceImpl.Status)
          .AddMethod(__Method_GetCategories, serviceImpl.GetCategories)
          .AddMethod(__Method_GetArticle, serviceImpl.GetArticle)
          .AddMethod(__Method_GetArticles, serviceImpl.GetArticles).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CrawlerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Start, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.StartRequest, global::CrawlerGRPC.StartResponse>(serviceImpl.Start));
      serviceBinder.AddMethod(__Method_Stop, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.StopRequest, global::CrawlerGRPC.StopResponse>(serviceImpl.Stop));
      serviceBinder.AddMethod(__Method_Crawl, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.CrawlRequest, global::CrawlerGRPC.CrawlResponse>(serviceImpl.Crawl));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.DeleteRequest, global::CrawlerGRPC.DeleteResponse>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_Status, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.StatusRequest, global::CrawlerGRPC.StatusResponse>(serviceImpl.Status));
      serviceBinder.AddMethod(__Method_GetCategories, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.CategoriesRequest, global::CrawlerGRPC.CategoriesResponse>(serviceImpl.GetCategories));
      serviceBinder.AddMethod(__Method_GetArticle, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.ArticleRequest, global::CrawlerGRPC.ArticleResponse>(serviceImpl.GetArticle));
      serviceBinder.AddMethod(__Method_GetArticles, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CrawlerGRPC.ArticlesRequest, global::CrawlerGRPC.ArticlesResponse>(serviceImpl.GetArticles));
    }

  }
}
#endregion
