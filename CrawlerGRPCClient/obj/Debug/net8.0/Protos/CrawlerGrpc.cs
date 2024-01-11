// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/crawler.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CrawlerGRPCClient {
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
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.StartRequest> __Marshaller_crawler_StartRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.StartRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.StartResponse> __Marshaller_crawler_StartResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.StartResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.StopRequest> __Marshaller_crawler_StopRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.StopRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.StopResponse> __Marshaller_crawler_StopResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.StopResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.CrawlRequest> __Marshaller_crawler_CrawlRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.CrawlRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.CrawlResponse> __Marshaller_crawler_CrawlResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.CrawlResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.DeleteRequest> __Marshaller_crawler_DeleteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.DeleteRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.DeleteResponse> __Marshaller_crawler_DeleteResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.DeleteResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.StatusRequest> __Marshaller_crawler_StatusRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.StatusRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.StatusResponse> __Marshaller_crawler_StatusResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.StatusResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.CategoriesRequest> __Marshaller_crawler_CategoriesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.CategoriesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.CategoriesResponse> __Marshaller_crawler_CategoriesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.CategoriesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.ArticleRequest> __Marshaller_crawler_ArticleRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.ArticleRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.ArticleResponse> __Marshaller_crawler_ArticleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.ArticleResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.ArticlesRequest> __Marshaller_crawler_ArticlesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.ArticlesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CrawlerGRPCClient.ArticlesResponse> __Marshaller_crawler_ArticlesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CrawlerGRPCClient.ArticlesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.StartRequest, global::CrawlerGRPCClient.StartResponse> __Method_Start = new grpc::Method<global::CrawlerGRPCClient.StartRequest, global::CrawlerGRPCClient.StartResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Start",
        __Marshaller_crawler_StartRequest,
        __Marshaller_crawler_StartResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.StopRequest, global::CrawlerGRPCClient.StopResponse> __Method_Stop = new grpc::Method<global::CrawlerGRPCClient.StopRequest, global::CrawlerGRPCClient.StopResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Stop",
        __Marshaller_crawler_StopRequest,
        __Marshaller_crawler_StopResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.CrawlRequest, global::CrawlerGRPCClient.CrawlResponse> __Method_Crawl = new grpc::Method<global::CrawlerGRPCClient.CrawlRequest, global::CrawlerGRPCClient.CrawlResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Crawl",
        __Marshaller_crawler_CrawlRequest,
        __Marshaller_crawler_CrawlResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.DeleteRequest, global::CrawlerGRPCClient.DeleteResponse> __Method_Delete = new grpc::Method<global::CrawlerGRPCClient.DeleteRequest, global::CrawlerGRPCClient.DeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_crawler_DeleteRequest,
        __Marshaller_crawler_DeleteResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.StatusRequest, global::CrawlerGRPCClient.StatusResponse> __Method_Status = new grpc::Method<global::CrawlerGRPCClient.StatusRequest, global::CrawlerGRPCClient.StatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Status",
        __Marshaller_crawler_StatusRequest,
        __Marshaller_crawler_StatusResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.CategoriesRequest, global::CrawlerGRPCClient.CategoriesResponse> __Method_GetCategories = new grpc::Method<global::CrawlerGRPCClient.CategoriesRequest, global::CrawlerGRPCClient.CategoriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategories",
        __Marshaller_crawler_CategoriesRequest,
        __Marshaller_crawler_CategoriesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.ArticleRequest, global::CrawlerGRPCClient.ArticleResponse> __Method_GetArticle = new grpc::Method<global::CrawlerGRPCClient.ArticleRequest, global::CrawlerGRPCClient.ArticleResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetArticle",
        __Marshaller_crawler_ArticleRequest,
        __Marshaller_crawler_ArticleResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CrawlerGRPCClient.ArticlesRequest, global::CrawlerGRPCClient.ArticlesResponse> __Method_GetArticles = new grpc::Method<global::CrawlerGRPCClient.ArticlesRequest, global::CrawlerGRPCClient.ArticlesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetArticles",
        __Marshaller_crawler_ArticlesRequest,
        __Marshaller_crawler_ArticlesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CrawlerGRPCClient.CrawlerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Crawler</summary>
    public partial class CrawlerClient : grpc::ClientBase<CrawlerClient>
    {
      /// <summary>Creates a new client for Crawler</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CrawlerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Crawler that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CrawlerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CrawlerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CrawlerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.StartResponse Start(global::CrawlerGRPCClient.StartRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Start(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.StartResponse Start(global::CrawlerGRPCClient.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Start, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.StartResponse> StartAsync(global::CrawlerGRPCClient.StartRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.StartResponse> StartAsync(global::CrawlerGRPCClient.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Start, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.StopResponse Stop(global::CrawlerGRPCClient.StopRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Stop(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.StopResponse Stop(global::CrawlerGRPCClient.StopRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Stop, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.StopResponse> StopAsync(global::CrawlerGRPCClient.StopRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StopAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.StopResponse> StopAsync(global::CrawlerGRPCClient.StopRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Stop, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.CrawlResponse Crawl(global::CrawlerGRPCClient.CrawlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Crawl(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.CrawlResponse Crawl(global::CrawlerGRPCClient.CrawlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Crawl, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.CrawlResponse> CrawlAsync(global::CrawlerGRPCClient.CrawlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CrawlAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.CrawlResponse> CrawlAsync(global::CrawlerGRPCClient.CrawlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Crawl, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.DeleteResponse Delete(global::CrawlerGRPCClient.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.DeleteResponse Delete(global::CrawlerGRPCClient.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.DeleteResponse> DeleteAsync(global::CrawlerGRPCClient.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.DeleteResponse> DeleteAsync(global::CrawlerGRPCClient.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.StatusResponse Status(global::CrawlerGRPCClient.StatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Status(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.StatusResponse Status(global::CrawlerGRPCClient.StatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Status, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.StatusResponse> StatusAsync(global::CrawlerGRPCClient.StatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.StatusResponse> StatusAsync(global::CrawlerGRPCClient.StatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Status, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.CategoriesResponse GetCategories(global::CrawlerGRPCClient.CategoriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategories(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.CategoriesResponse GetCategories(global::CrawlerGRPCClient.CategoriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCategories, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.CategoriesResponse> GetCategoriesAsync(global::CrawlerGRPCClient.CategoriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoriesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.CategoriesResponse> GetCategoriesAsync(global::CrawlerGRPCClient.CategoriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCategories, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.ArticleResponse GetArticle(global::CrawlerGRPCClient.ArticleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetArticle(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.ArticleResponse GetArticle(global::CrawlerGRPCClient.ArticleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArticle, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.ArticleResponse> GetArticleAsync(global::CrawlerGRPCClient.ArticleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetArticleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.ArticleResponse> GetArticleAsync(global::CrawlerGRPCClient.ArticleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArticle, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.ArticlesResponse GetArticles(global::CrawlerGRPCClient.ArticlesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetArticles(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CrawlerGRPCClient.ArticlesResponse GetArticles(global::CrawlerGRPCClient.ArticlesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArticles, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.ArticlesResponse> GetArticlesAsync(global::CrawlerGRPCClient.ArticlesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetArticlesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CrawlerGRPCClient.ArticlesResponse> GetArticlesAsync(global::CrawlerGRPCClient.ArticlesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArticles, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CrawlerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CrawlerClient(configuration);
      }
    }

  }
}
#endregion