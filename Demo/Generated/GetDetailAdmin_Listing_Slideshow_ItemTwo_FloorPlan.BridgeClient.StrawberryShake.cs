﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetDetailAdmin_Listing_Slideshow_ItemTwo_FloorPlan : global::System.IEquatable<GetDetailAdmin_Listing_Slideshow_ItemTwo_FloorPlan>, IGetDetailAdmin_Listing_Slideshow_ItemTwo_FloorPlan
    {
        public GetDetailAdmin_Listing_Slideshow_ItemTwo_FloorPlan()
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

            return Equals((GetDetailAdmin_Listing_Slideshow_ItemTwo_FloorPlan)obj);
        }

        public global::System.Boolean Equals(GetDetailAdmin_Listing_Slideshow_ItemTwo_FloorPlan? other)
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
