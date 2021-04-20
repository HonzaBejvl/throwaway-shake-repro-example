﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddPhotoResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Logic.Graphql.Generated.ListingAddPhotoResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public ListingAddPhotoResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Logic.Graphql.Generated.IListingAddPhotoResult);
        public ListingAddPhotoResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is ListingAddPhotoResultInfo info)
            {
                return new ListingAddPhotoResult(MapNonNullableIListingAddPhoto_ListingAddPhoto(info.ListingAddPhoto, snapshot));
            }

            throw new global::System.ArgumentException("ListingAddPhotoResultInfo expected.");
        }

        private global::Logic.Graphql.Generated.IListingAddPhoto_ListingAddPhoto MapNonNullableIListingAddPhoto_ListingAddPhoto(global::Logic.Graphql.Generated.State.ListingAddPhotoPayloadData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IListingAddPhoto_ListingAddPhoto returnValue = default !;
            if (data.__typename.Equals("ListingAddPhotoPayload", global::System.StringComparison.Ordinal))
            {
                returnValue = new ListingAddPhoto_ListingAddPhoto_ListingAddPhotoPayload(MapNonNullableIListingAddPhoto_ListingAddPhoto_Result(data.Result ?? throw new global::System.ArgumentNullException(), snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IListingAddPhoto_ListingAddPhoto_Result MapNonNullableIListingAddPhoto_ListingAddPhoto_Result(global::Logic.Graphql.Generated.State.PhotoData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IListingAddPhoto_ListingAddPhoto_Result returnValue = default !;
            if (data.__typename.Equals("Photo", global::System.StringComparison.Ordinal))
            {
                returnValue = new ListingAddPhoto_ListingAddPhoto_Result_Photo(data.FigureId ?? throw new global::System.ArgumentNullException(), data.Url ?? throw new global::System.ArgumentNullException(), data.OriginalUrl ?? throw new global::System.ArgumentNullException(), data.Is360 ?? throw new global::System.ArgumentNullException());
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
