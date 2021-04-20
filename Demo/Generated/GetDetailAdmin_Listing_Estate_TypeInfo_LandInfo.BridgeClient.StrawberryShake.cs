﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Doplnující informace pro pozemky
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetDetailAdmin_Listing_Estate_TypeInfo_LandInfo : global::System.IEquatable<GetDetailAdmin_Listing_Estate_TypeInfo_LandInfo>, IGetDetailAdmin_Listing_Estate_TypeInfo_LandInfo
    {
        public GetDetailAdmin_Listing_Estate_TypeInfo_LandInfo(global::Logic.Graphql.Generated.LandType landlType, global::System.Double landArea)
        {
            LandlType = landlType;
            LandArea = landArea;
        }

        public global::Logic.Graphql.Generated.LandType LandlType { get; }

        public global::System.Double LandArea { get; }

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

            return Equals((GetDetailAdmin_Listing_Estate_TypeInfo_LandInfo)obj);
        }

        public global::System.Boolean Equals(GetDetailAdmin_Listing_Estate_TypeInfo_LandInfo? other)
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

            return (LandlType.Equals(other.LandlType)) && LandArea == other.LandArea;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * LandlType.GetHashCode();
                hash ^= 397 * LandArea.GetHashCode();
                return hash;
            }
        }
    }
}
