﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the ListingAddFloorPlan GraphQL operation
    /// <code>
    /// mutation ListingAddFloorPlan($listingId: ID!, $floorPlanUrl: Url!) {
    ///   listingAddFloorPlan(listingId: $listingId, floorPlanUrl: $floorPlanUrl) {
    ///     __typename
    ///     ... ListingAddFloorPlanPayload
    ///   }
    /// }
    /// 
    /// fragment ListingAddFloorPlanPayload on ListingAddFloorPlanPayload {
    ///   result {
    ///     __typename
    ///     ... FloorPlan
    ///   }
    /// }
    /// 
    /// fragment FloorPlan on FloorPlan {
    ///   figureId
    ///   url
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddFloorPlanMutation : global::Logic.Graphql.Generated.IListingAddFloorPlanMutation
    {
        private readonly global::StrawberryShake.IOperationExecutor<IListingAddFloorPlanResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _iDFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _urlFormatter;
        public ListingAddFloorPlanMutation(global::StrawberryShake.IOperationExecutor<IListingAddFloorPlanResult> operationExecutor, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _iDFormatter = serializerResolver.GetInputValueFormatter("ID");
            _urlFormatter = serializerResolver.GetInputValueFormatter("Url");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IListingAddFloorPlanResult);
        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IListingAddFloorPlanResult>> ExecuteAsync(global::System.String listingId, global::System.Uri floorPlanUrl, global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(listingId, floorPlanUrl);
            return await _operationExecutor.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IListingAddFloorPlanResult>> Watch(global::System.String listingId, global::System.Uri floorPlanUrl, global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(listingId, floorPlanUrl);
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.String listingId, global::System.Uri floorPlanUrl)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();
            variables.Add("listingId", FormatListingId(listingId));
            variables.Add("floorPlanUrl", FormatFloorPlanUrl(floorPlanUrl));
            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: ListingAddFloorPlanMutationDocument.Instance.Hash.Value, name: "ListingAddFloorPlan", document: ListingAddFloorPlanMutationDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default, variables: variables);
        }

        private global::System.Object? FormatListingId(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _iDFormatter.Format(value);
        }

        private global::System.Object? FormatFloorPlanUrl(global::System.Uri value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _urlFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}