﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingFilterInputValueFormatter : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _listingTypeFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _serviceTypeFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _estateTypeFilterFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _intRangeFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _locationFilterFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _featuresFilterFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _amenitiesFilterFormatter = default !;
        public global::System.String TypeName => "ListingFilter";
        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _listingTypeFormatter = serializerResolver.GetInputValueFormatter("ListingType");
            _serviceTypeFormatter = serializerResolver.GetInputValueFormatter("ServiceType");
            _estateTypeFilterFormatter = serializerResolver.GetInputValueFormatter("EstateTypeFilter");
            _intRangeFormatter = serializerResolver.GetInputValueFormatter("IntRange");
            _locationFilterFormatter = serializerResolver.GetInputValueFormatter("LocationFilter");
            _featuresFilterFormatter = serializerResolver.GetInputValueFormatter("FeaturesFilter");
            _amenitiesFilterFormatter = serializerResolver.GetInputValueFormatter("AmenitiesFilter");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            var input = runtimeValue as global::Logic.Graphql.Generated.ListingFilter;
            var inputInfo = runtimeValue as global::Logic.Graphql.Generated.State.IListingFilterInfo;
            if (input is null || inputInfo is null)
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            var fields = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>>();
            if (inputInfo.IsListingTypeSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("listingType", FormatListingType(input.ListingType)));
            }

            if (inputInfo.IsServiceTypeSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("serviceType", FormatServiceType(input.ServiceType)));
            }

            if (inputInfo.IsEstateTypeSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("estateType", FormatEstateType(input.EstateType)));
            }

            if (inputInfo.IsPriceSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("price", FormatPrice(input.Price)));
            }

            if (inputInfo.IsLocationSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("location", FormatLocation(input.Location)));
            }

            if (inputInfo.IsFeaturesSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("features", FormatFeatures(input.Features)));
            }

            if (inputInfo.IsAmenitiesSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("amenities", FormatAmenities(input.Amenities)));
            }

            if (inputInfo.IsUsableAreaSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("usableArea", FormatUsableArea(input.UsableArea)));
            }

            if (inputInfo.IsLandAreaSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("landArea", FormatLandArea(input.LandArea)));
            }

            if (inputInfo.IsConstructionYearSet)
            {
                fields.Add(new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("constructionYear", FormatConstructionYear(input.ConstructionYear)));
            }

            return fields;
        }

        private global::System.Object? FormatListingType(global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.ListingType>? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                var input_list = new global::System.Collections.Generic.List<global::System.Object?>();
                foreach (var input_elm in input)
                {
                    input_list.Add(_listingTypeFormatter.Format(input_elm));
                }

                return input_list;
            }
        }

        private global::System.Object? FormatServiceType(global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.ServiceType>? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                var input_list = new global::System.Collections.Generic.List<global::System.Object?>();
                foreach (var input_elm in input)
                {
                    input_list.Add(_serviceTypeFormatter.Format(input_elm));
                }

                return input_list;
            }
        }

        private global::System.Object? FormatEstateType(global::Logic.Graphql.Generated.EstateTypeFilter? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _estateTypeFilterFormatter.Format(input);
            }
        }

        private global::System.Object? FormatPrice(global::Logic.Graphql.Generated.IntRange? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _intRangeFormatter.Format(input);
            }
        }

        private global::System.Object? FormatLocation(global::Logic.Graphql.Generated.LocationFilter? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _locationFilterFormatter.Format(input);
            }
        }

        private global::System.Object? FormatFeatures(global::Logic.Graphql.Generated.FeaturesFilter? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _featuresFilterFormatter.Format(input);
            }
        }

        private global::System.Object? FormatAmenities(global::Logic.Graphql.Generated.AmenitiesFilter? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _amenitiesFilterFormatter.Format(input);
            }
        }

        private global::System.Object? FormatUsableArea(global::Logic.Graphql.Generated.IntRange? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _intRangeFormatter.Format(input);
            }
        }

        private global::System.Object? FormatLandArea(global::Logic.Graphql.Generated.IntRange? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _intRangeFormatter.Format(input);
            }
        }

        private global::System.Object? FormatConstructionYear(global::Logic.Graphql.Generated.IntRange? input)
        {
            if (input is null)
            {
                return input;
            }
            else
            {
                return _intRangeFormatter.Format(input);
            }
        }
    }
}
