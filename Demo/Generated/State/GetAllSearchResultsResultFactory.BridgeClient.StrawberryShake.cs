﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetAllSearchResultsResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Logic.Graphql.Generated.GetAllSearchResultsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetAllSearchResultsResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Logic.Graphql.Generated.IGetAllSearchResultsResult);
        public GetAllSearchResultsResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetAllSearchResultsResultInfo info)
            {
                return new GetAllSearchResultsResult(MapNonNullableIGetAllSearchResults_SearchNonNullableArray(info.Search, snapshot));
            }

            throw new global::System.ArgumentException("GetAllSearchResultsResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetAllSearchResults_Search> MapNonNullableIGetAllSearchResults_SearchNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.State.ISearchResultData>? list, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var searchResults = new global::System.Collections.Generic.List<global::Logic.Graphql.Generated.IGetAllSearchResults_Search>();
            foreach (global::Logic.Graphql.Generated.State.ISearchResultData child in list)
            {
                searchResults.Add(MapNonNullableIGetAllSearchResults_Search(child, snapshot));
            }

            return searchResults;
        }

        private global::Logic.Graphql.Generated.IGetAllSearchResults_Search MapNonNullableIGetAllSearchResults_Search(global::Logic.Graphql.Generated.State.ISearchResultData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetAllSearchResults_Search? returnValue;
            if (data is global::Logic.Graphql.Generated.State.OfferData offer)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Offer();
            }
            else if (data is global::Logic.Graphql.Generated.State.AuctionData auction)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Auction();
            }
            else if (data is global::Logic.Graphql.Generated.State.ProjectData project)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Project();
            }
            else if (data is global::Logic.Graphql.Generated.State.BrokerData broker)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Broker(broker.SellerId ?? throw new global::System.ArgumentNullException(), broker.Name ?? throw new global::System.ArgumentNullException(), MapNonNullableIGetDetail_Listing_Seller_Photo(broker.Photo, snapshot), MapNonNullableIGetDetail_Listing_Seller_Company_3(broker.Company, snapshot));
            }
            else if (data is global::Logic.Graphql.Generated.State.OfficeData office)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Office();
            }
            else if (data is global::Logic.Graphql.Generated.State.CompanyData company)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Company();
            }
            else if (data is global::Logic.Graphql.Generated.State.LocationData location)
            {
                returnValue = new global::Logic.Graphql.Generated.GetAllSearchResults_Search_Location(location.Type ?? throw new global::System.ArgumentNullException(), MapNonNullableIGetAllSearchResults_Search_Viewport(location.Viewport, snapshot), location.Region_name ?? throw new global::System.ArgumentNullException(), location.District_name, location.City_name, location.City_part_name, location.Street_name);
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo MapNonNullableIGetDetail_Listing_Seller_Photo(global::Logic.Graphql.Generated.State.PhotoData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetDetail_Listing_Seller_Photo returnValue = default !;
            if (data.__typename.Equals("Photo", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetDetail_Listing_Seller_Photo_Photo(data.FigureId ?? throw new global::System.ArgumentNullException(), data.Url ?? throw new global::System.ArgumentNullException(), data.OriginalUrl ?? throw new global::System.ArgumentNullException(), data.Is360 ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Company_3 MapNonNullableIGetDetail_Listing_Seller_Company_3(global::Logic.Graphql.Generated.State.CompanyData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetDetail_Listing_Seller_Company_3 returnValue = default !;
            if (data.__typename.Equals("Company", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetDetail_Listing_Seller_Company_Company(data.Name ?? throw new global::System.ArgumentNullException(), MapNonNullableIGetDetail_Listing_Seller_Photo_1(data.Photo ?? throw new global::System.ArgumentNullException(), snapshot), MapNonNullableIGetDetail_Listing_Seller_Headquarters(data.Headquarters ?? throw new global::System.ArgumentNullException(), snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_1 MapNonNullableIGetDetail_Listing_Seller_Photo_1(global::Logic.Graphql.Generated.State.PhotoData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetDetail_Listing_Seller_Photo_1 returnValue = default !;
            if (data.__typename.Equals("Photo", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetDetail_Listing_Seller_Photo_Photo_1(data.FigureId ?? throw new global::System.ArgumentNullException(), data.Url ?? throw new global::System.ArgumentNullException(), data.OriginalUrl ?? throw new global::System.ArgumentNullException(), data.Is360 ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Headquarters MapNonNullableIGetDetail_Listing_Seller_Headquarters(global::Logic.Graphql.Generated.State.AddressData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetDetail_Listing_Seller_Headquarters returnValue = default !;
            if (data.__typename.Equals("Address", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetDetail_Listing_Seller_Headquarters_Address(data.Lat ?? throw new global::System.ArgumentNullException(), data.Lng ?? throw new global::System.ArgumentNullException(), data.CityName ?? throw new global::System.ArgumentNullException(), data.StreetName, data.RuianCode ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetAllSearchResults_Search_Viewport MapNonNullableIGetAllSearchResults_Search_Viewport(global::Logic.Graphql.Generated.State.ViewportData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetAllSearchResults_Search_Viewport returnValue = default !;
            if (data.__typename.Equals("Viewport", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetAllSearchResults_Search_Viewport_Viewport(MapNonNullableIGetAllSearchResults_Search_Viewport_Top_left(data.Top_left ?? throw new global::System.ArgumentNullException(), snapshot), MapNonNullableIGetAllSearchResults_Search_Viewport_Bottom_right(data.Bottom_right ?? throw new global::System.ArgumentNullException(), snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetAllSearchResults_Search_Viewport_Top_left MapNonNullableIGetAllSearchResults_Search_Viewport_Top_left(global::Logic.Graphql.Generated.State.GpsData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetAllSearchResults_Search_Viewport_Top_left returnValue = default !;
            if (data.__typename.Equals("Gps", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetAllSearchResults_Search_Viewport_Top_left_Gps(data.Lat ?? throw new global::System.ArgumentNullException(), data.Lng ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetAllSearchResults_Search_Viewport_Bottom_right MapNonNullableIGetAllSearchResults_Search_Viewport_Bottom_right(global::Logic.Graphql.Generated.State.GpsData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetAllSearchResults_Search_Viewport_Bottom_right returnValue = default !;
            if (data.__typename.Equals("Gps", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetAllSearchResults_Search_Viewport_Bottom_right_Gps(data.Lat ?? throw new global::System.ArgumentNullException(), data.Lng ?? throw new global::System.ArgumentNullException());
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