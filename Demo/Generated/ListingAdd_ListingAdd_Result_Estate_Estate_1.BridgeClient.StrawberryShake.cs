﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Nemovitost - popis nemovitosti
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAdd_ListingAdd_Result_Estate_Estate_1 : global::System.IEquatable<ListingAdd_ListingAdd_Result_Estate_Estate_1>, IListingAdd_ListingAdd_Result_Estate_Estate_1
    {
        public ListingAdd_ListingAdd_Result_Estate_Estate_1(global::Logic.Graphql.Generated.EstateType type, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Electricity> electricity, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Gas> gas, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Water> water, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Heating> heating, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Waste> waste, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Road> road, global::Logic.Graphql.Generated.NatureProtection natureProtection, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Connectivity> connectivity, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Estate_TypeInfo typeInfo, global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Estate_FullAddress fullAddress)
        {
            Type = type;
            Electricity = electricity;
            Gas = gas;
            Water = water;
            Heating = heating;
            Waste = waste;
            Road = road;
            NatureProtection = natureProtection;
            Connectivity = connectivity;
            TypeInfo = typeInfo;
            FullAddress = fullAddress;
        }

        public global::Logic.Graphql.Generated.EstateType Type { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Electricity> Electricity { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Gas> Gas { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Water> Water { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Heating> Heating { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Waste> Waste { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Road> Road { get; }

        public global::Logic.Graphql.Generated.NatureProtection NatureProtection { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Connectivity> Connectivity { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Estate_TypeInfo TypeInfo { get; }

        public global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Estate_FullAddress FullAddress { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((ListingAdd_ListingAdd_Result_Estate_Estate_1)obj);
        }

        public global::System.Boolean Equals(ListingAdd_ListingAdd_Result_Estate_Estate_1? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Type.Equals(other.Type)) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Electricity, other.Electricity) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Gas, other.Gas) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Water, other.Water) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Heating, other.Heating) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Waste, other.Waste) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Road, other.Road) && NatureProtection.Equals(other.NatureProtection) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Connectivity, other.Connectivity) && TypeInfo.Equals(other.TypeInfo) && FullAddress.Equals(other.FullAddress);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Type.GetHashCode();
                foreach (var Electricity_elm in Electricity)
                {
                    hash ^= 397 * Electricity_elm.GetHashCode();
                }

                foreach (var Gas_elm in Gas)
                {
                    hash ^= 397 * Gas_elm.GetHashCode();
                }

                foreach (var Water_elm in Water)
                {
                    hash ^= 397 * Water_elm.GetHashCode();
                }

                foreach (var Heating_elm in Heating)
                {
                    hash ^= 397 * Heating_elm.GetHashCode();
                }

                foreach (var Waste_elm in Waste)
                {
                    hash ^= 397 * Waste_elm.GetHashCode();
                }

                foreach (var Road_elm in Road)
                {
                    hash ^= 397 * Road_elm.GetHashCode();
                }

                hash ^= 397 * NatureProtection.GetHashCode();
                foreach (var Connectivity_elm in Connectivity)
                {
                    hash ^= 397 * Connectivity_elm.GetHashCode();
                }

                hash ^= 397 * TypeInfo.GetHashCode();
                hash ^= 397 * FullAddress.GetHashCode();
                return hash;
            }
        }
    }
}
