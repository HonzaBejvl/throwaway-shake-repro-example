﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetFilterCountBuilder : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Logic.Graphql.Generated.IGetFilterCountResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Logic.Graphql.Generated.IGetFilterCountResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.ListingType> _listingTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.ServiceType> _serviceTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.EstateType> _estateTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.ApartmentType> _apartmentTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.HouseType> _houseTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.LandType> _landTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.CommercialType> _commercialTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Logic.Graphql.Generated.GarageType> _garageTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Double, global::System.Double> _floatParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Boolean, global::System.Boolean> _booleanParser;
        public GetFilterCountBuilder(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer idSerializer, global::StrawberryShake.IOperationResultDataFactory<global::Logic.Graphql.Generated.IGetFilterCountResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _listingTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.ListingType>("ListingType") ?? throw new global::System.ArgumentException("No serializer for type `ListingType` found.");
            _serviceTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.ServiceType>("ServiceType") ?? throw new global::System.ArgumentException("No serializer for type `ServiceType` found.");
            _estateTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.EstateType>("EstateType") ?? throw new global::System.ArgumentException("No serializer for type `EstateType` found.");
            _apartmentTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.ApartmentType>("ApartmentType") ?? throw new global::System.ArgumentException("No serializer for type `ApartmentType` found.");
            _houseTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.HouseType>("HouseType") ?? throw new global::System.ArgumentException("No serializer for type `HouseType` found.");
            _landTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.LandType>("LandType") ?? throw new global::System.ArgumentException("No serializer for type `LandType` found.");
            _commercialTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.CommercialType>("CommercialType") ?? throw new global::System.ArgumentException("No serializer for type `CommercialType` found.");
            _garageTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Logic.Graphql.Generated.GarageType>("GarageType") ?? throw new global::System.ArgumentException("No serializer for type `GarageType` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int") ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _floatParser = serializerResolver.GetLeafValueParser<global::System.Double, global::System.Double>("Float") ?? throw new global::System.ArgumentException("No serializer for type `Float` found.");
            _booleanParser = serializerResolver.GetLeafValueParser<global::System.Boolean, global::System.Boolean>("Boolean") ?? throw new global::System.ArgumentException("No serializer for type `Boolean` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetFilterCountResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetFilterCountResult Result, GetFilterCountResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;
            if (response.Exception is null)
            {
                try
                {
                    if (response.Body != null)
                    {
                        if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                        {
                            data = BuildData(dataElement);
                        }

                        if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                        {
                            errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                        }
                    }
                }
                catch (global::System.Exception ex)
                {
                    errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(ex.Message, exception: ex, extensions: new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>{{"body", response.Body?.RootElement.ToString()}})};
                }
            }
            else
            {
                errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(response.Exception.Message, exception: response.Exception, extensions: new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>{{"body", response.Body?.RootElement.ToString()}})};
            }

            return new global::StrawberryShake.OperationResult<IGetFilterCountResult>(data?.Result, data?.Info, _resultDataFactory, errors);
        }

        private (IGetFilterCountResult, GetFilterCountResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default !;
            _entityStore.Update(session =>
            {
                snapshot = session.CurrentSnapshot;
            });
            var resultInfo = new GetFilterCountResultInfo(DeserializeNonNullableIGetFilterCount_Listings(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "listings")), entityIds, snapshot.Version);
            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::Logic.Graphql.Generated.State.ListingsPayloadData DeserializeNonNullableIGetFilterCount_Listings(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value.GetProperty("__typename").GetString();
            if (typename?.Equals("ListingsPayload", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Logic.Graphql.Generated.State.ListingsPayloadData(typename, count: DeserializeNonNullableInt32(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "count")));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }
    }
}