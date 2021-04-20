﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetFilterCount GraphQL operation
    /// <code>
    /// query GetFilterCount($filter: ListingFilter!) {
    ///   listings(filter: $filter) {
    ///     __typename
    ///     ... ListingsPayloadCount
    ///   }
    /// }
    /// 
    /// fragment ListingsPayloadCount on ListingsPayload {
    ///   count
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetFilterCountQuery : global::Logic.Graphql.Generated.IGetFilterCountQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetFilterCountResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _listingFilterFormatter;
        public GetFilterCountQuery(global::StrawberryShake.IOperationExecutor<IGetFilterCountResult> operationExecutor, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _listingFilterFormatter = serializerResolver.GetInputValueFormatter("ListingFilter");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetFilterCountResult);
        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetFilterCountResult>> ExecuteAsync(global::Logic.Graphql.Generated.ListingFilter filter, global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(filter);
            return await _operationExecutor.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetFilterCountResult>> Watch(global::Logic.Graphql.Generated.ListingFilter filter, global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(filter);
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::Logic.Graphql.Generated.ListingFilter filter)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();
            variables.Add("filter", FormatFilter(filter));
            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: GetFilterCountQueryDocument.Instance.Hash.Value, name: "GetFilterCount", document: GetFilterCountQueryDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default, variables: variables);
        }

        private global::System.Object? FormatFilter(global::Logic.Graphql.Generated.ListingFilter value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _listingFilterFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}