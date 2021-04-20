﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetAllSearchResultsResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public GetAllSearchResultsResultInfo(global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.State.ISearchResultData> search, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            Search = search;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        /// <summary>
        /// Vyhledávání v obsahu nemovizoru
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.State.ISearchResultData> Search { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetAllSearchResultsResultInfo(Search, _entityIds, version);
        }
    }
}
