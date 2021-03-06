// <auto-generated/>
#nullable enable

namespace Demo.Graphql
{
    /// <summary>
    /// Represents the operation service of the GetAll GraphQL operation
    /// <code>
    /// query GetAll {
    ///   listings {
    ///     __typename
    ///     ... AllListing
    ///   }
    /// }
    /// 
    /// fragment AllListing on Listing {
    ///   ... Offer
    ///   ... Auction
    /// }
    /// 
    /// fragment Offer on Offer {
    ///   serviceType
    /// }
    /// 
    /// fragment Auction on Auction {
    ///   serviceType
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public interface IGetAllQuery : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetAllResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetAllResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}
