﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetCard_Listing_Slideshow_Item_FloorPlan : global::System.IEquatable<GetCard_Listing_Slideshow_Item_FloorPlan>, IGetCard_Listing_Slideshow_Item_FloorPlan
    {
        public GetCard_Listing_Slideshow_Item_FloorPlan()
        {
        }

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

            return Equals((GetCard_Listing_Slideshow_Item_FloorPlan)obj);
        }

        public global::System.Boolean Equals(GetCard_Listing_Slideshow_Item_FloorPlan? other)
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

            return true;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                return hash;
            }
        }
    }
}
