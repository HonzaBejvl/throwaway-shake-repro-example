﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Výsledek operace přidání FloorPlan k nabídce.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddFloorPlan_ListingAddFloorPlan_ListingAddFloorPlanPayload : global::System.IEquatable<ListingAddFloorPlan_ListingAddFloorPlan_ListingAddFloorPlanPayload>, IListingAddFloorPlan_ListingAddFloorPlan_ListingAddFloorPlanPayload
    {
        public ListingAddFloorPlan_ListingAddFloorPlan_ListingAddFloorPlanPayload(global::Logic.Graphql.Generated.IListingAddFloorPlan_ListingAddFloorPlan_Result result)
        {
            Result = result;
        }

        public global::Logic.Graphql.Generated.IListingAddFloorPlan_ListingAddFloorPlan_Result Result { get; }

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

            return Equals((ListingAddFloorPlan_ListingAddFloorPlan_ListingAddFloorPlanPayload)obj);
        }

        public global::System.Boolean Equals(ListingAddFloorPlan_ListingAddFloorPlan_ListingAddFloorPlanPayload? other)
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

            return (Result.Equals(other.Result));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Result.GetHashCode();
                return hash;
            }
        }
    }
}
