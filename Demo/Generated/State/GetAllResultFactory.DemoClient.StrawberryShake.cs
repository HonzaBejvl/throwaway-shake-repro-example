﻿// <auto-generated/>
#nullable enable

namespace Demo.Graphql.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetAllResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Demo.Graphql.GetAllResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetAllResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Demo.Graphql.IGetAllResult);
        public GetAllResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetAllResultInfo info)
            {
                return new GetAllResult(MapNonNullableIGetAll_ListingsNonNullableArray(info.Listings, snapshot));
            }

            throw new global::System.ArgumentException("GetAllResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Demo.Graphql.IGetAll_Listings> MapNonNullableIGetAll_ListingsNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::Demo.Graphql.State.IListingData>? list, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var listings = new global::System.Collections.Generic.List<global::Demo.Graphql.IGetAll_Listings>();
            foreach (global::Demo.Graphql.State.IListingData child in list)
            {
                listings.Add(MapNonNullableIGetAll_Listings(child, snapshot));
            }

            return listings;
        }

        private global::Demo.Graphql.IGetAll_Listings MapNonNullableIGetAll_Listings(global::Demo.Graphql.State.IListingData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetAll_Listings? returnValue;
            if (data is global::Demo.Graphql.State.OfferData offer)
            {
                if (offer.ServiceType.HasValue)
                {
                    throw new global::System.ArgumentNullException();
                }

                returnValue = new global::Demo.Graphql.GetAll_Listings_Offer(offer.ServiceType!.Value);
            }
            else if (data is global::Demo.Graphql.State.AuctionData auction)
            {
                if (auction.ServiceType.HasValue)
                {
                    throw new global::System.ArgumentNullException();
                }

                returnValue = new global::Demo.Graphql.GetAll_Listings_Auction(auction.ServiceType!.Value);
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }
}