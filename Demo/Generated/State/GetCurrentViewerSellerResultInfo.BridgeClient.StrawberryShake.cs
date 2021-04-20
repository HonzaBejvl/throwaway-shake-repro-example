﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetCurrentViewerSellerResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public GetCurrentViewerSellerResultInfo(global::Logic.Graphql.Generated.State.ViewerData viewer, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            Viewer = viewer;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        /// <summary>
        /// Aktuálně přihlášený uživatel
        /// </summary>
        public global::Logic.Graphql.Generated.State.ViewerData Viewer { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetCurrentViewerSellerResultInfo(Viewer, _entityIds, version);
        }
    }
}
