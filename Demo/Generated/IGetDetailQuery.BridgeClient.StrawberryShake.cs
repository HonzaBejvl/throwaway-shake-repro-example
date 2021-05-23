﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetDetail GraphQL operation
    /// <code>
    /// query GetDetail($listingId: ID!) {
    ///   listing(listingId: $listingId) {
    ///     __typename
    ///     ... ListingDetail
    ///   }
    /// }
    /// 
    /// fragment ListingDetail on Listing {
    ///   ... OfferDetail
    ///   ... AuctionDetail
    ///   ... ProjectDetail
    /// }
    /// 
    /// fragment OfferDetail on Offer {
    ///   estate {
    ///     __typename
    ///     ... Estate
    ///   }
    /// }
    /// 
    /// fragment Estate on Estate {
    ///   ... HasEstateTypeInfo
    /// }
    /// 
    /// fragment HasEstateTypeInfo on Estate {
    ///   typeInfo {
    ///     __typename
    ///     ... GarageInfo
    ///   }
    /// }
    /// 
    /// fragment GarageInfo on GarageInfo {
    ///   garageType: type
    ///   usableArea
    /// }
    /// 
    /// fragment AuctionDetail on Auction {
    ///   estate {
    ///     __typename
    ///     ... Estate
    ///   }
    /// }
    /// 
    /// fragment ProjectDetail on Project {
    ///   listings {
    ///     __typename
    ///     ... ProjectListingPayload
    ///   }
    /// }
    /// 
    /// fragment ProjectListingPayload on ProjectListingPayload {
    ///   items {
    ///     __typename
    ///     ... ProjectListing
    ///   }
    /// }
    /// 
    /// fragment ProjectListing on ProjectListing {
    ///   listing {
    ///     __typename
    ///     ... ProjectListingListing
    ///   }
    /// }
    /// 
    /// fragment ProjectListingListing on ListingSimple {
    ///   ... ProjectListingOffer
    ///   ... ProjectListingAuction
    /// }
    /// 
    /// fragment ProjectListingOffer on Offer {
    ///   estate {
    ///     __typename
    ///     ... EstateProject
    ///   }
    /// }
    /// 
    /// fragment EstateProject on Estate {
    ///   ... HasEstateProjectTypeInfo
    /// }
    /// 
    /// fragment HasEstateProjectTypeInfo on Estate {
    ///   typeInfo {
    ///     __typename
    ///     ... ProjectGarageInfo
    ///   }
    /// }
    /// 
    /// fragment ProjectGarageInfo on GarageInfo {
    ///   garageType: type
    /// }
    /// 
    /// fragment ProjectListingAuction on Auction {
    ///   estate {
    ///     __typename
    ///     ... EstateProject
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetDetailQuery : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetDetailResult>> ExecuteAsync(global::System.String listingId, global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetDetailResult>> Watch(global::System.String listingId, global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}
