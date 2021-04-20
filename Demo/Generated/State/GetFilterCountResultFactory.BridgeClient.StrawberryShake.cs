﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetFilterCountResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Logic.Graphql.Generated.GetFilterCountResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetFilterCountResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Logic.Graphql.Generated.IGetFilterCountResult);
        public GetFilterCountResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetFilterCountResultInfo info)
            {
                return new GetFilterCountResult(MapNonNullableIGetFilterCount_Listings(info.Listings, snapshot));
            }

            throw new global::System.ArgumentException("GetFilterCountResultInfo expected.");
        }

        private global::Logic.Graphql.Generated.IGetFilterCount_Listings MapNonNullableIGetFilterCount_Listings(global::Logic.Graphql.Generated.State.ListingsPayloadData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetFilterCount_Listings returnValue = default !;
            if (data.__typename.Equals("ListingsPayload", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetFilterCount_Listings_ListingsPayload(data.Count ?? throw new global::System.ArgumentNullException());
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