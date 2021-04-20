﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddFloorPlan_ListingAddFloorPlan_Result_FloorPlan : global::System.IEquatable<ListingAddFloorPlan_ListingAddFloorPlan_Result_FloorPlan>, IListingAddFloorPlan_ListingAddFloorPlan_Result_FloorPlan
    {
        public ListingAddFloorPlan_ListingAddFloorPlan_Result_FloorPlan(global::System.String figureId, global::System.Uri url)
        {
            FigureId = figureId;
            Url = url;
        }

        public global::System.String FigureId { get; }

        public global::System.Uri Url { get; }

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

            return Equals((ListingAddFloorPlan_ListingAddFloorPlan_Result_FloorPlan)obj);
        }

        public global::System.Boolean Equals(ListingAddFloorPlan_ListingAddFloorPlan_Result_FloorPlan? other)
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

            return (FigureId.Equals(other.FigureId)) && Url.Equals(other.Url);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * FigureId.GetHashCode();
                hash ^= 397 * Url.GetHashCode();
                return hash;
            }
        }
    }
}
