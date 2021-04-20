﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetSeller GraphQL operation
    /// <code>
    /// query GetSeller($sellerId: ID!) {
    ///   seller(sellerId: $sellerId) {
    ///     __typename
    ///     ... Seller
    ///   }
    /// }
    /// 
    /// fragment Seller on Seller {
    ///   ... Broker
    ///   ... Individual
    ///   ... Office
    ///   ... Company
    /// }
    /// 
    /// fragment Broker on Broker {
    ///   ... HasBrokerInformation
    ///   company {
    ///     __typename
    ///     ... Company
    ///   }
    /// }
    /// 
    /// fragment HasBrokerInformation on Broker {
    ///   sellerId
    ///   name
    ///   photo {
    ///     __typename
    ///     ... Photo
    ///   }
    /// }
    /// 
    /// fragment Photo on Photo {
    ///   figureId
    ///   url
    ///   originalUrl
    ///   is360
    /// }
    /// 
    /// fragment Company on Company {
    ///   ... HasCompanyInformation
    /// }
    /// 
    /// fragment HasCompanyInformation on Company {
    ///   name
    ///   photo {
    ///     __typename
    ///     ... Photo
    ///   }
    ///   headquarters {
    ///     __typename
    ///     ... Address
    ///   }
    /// }
    /// 
    /// fragment Address on Address {
    ///   lat
    ///   lng
    ///   cityName
    ///   streetName
    ///   ruianCode
    /// }
    /// 
    /// fragment Individual on Individual {
    ///   sellerId
    /// }
    /// 
    /// fragment Office on Office {
    ///   sellerId
    ///   name
    ///   photo {
    ///     __typename
    ///     ... Photo
    ///   }
    ///   company {
    ///     __typename
    ///     ... Company
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public interface IGetSellerQuery : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSellerResult>> ExecuteAsync(global::System.String sellerId, global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSellerResult>> Watch(global::System.String sellerId, global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}
