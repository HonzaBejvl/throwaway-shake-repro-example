﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Doplnující informace pro domy
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetDetail_Listing_Estate_TypeInfo_HouseInfo : global::System.IEquatable<GetDetail_Listing_Estate_TypeInfo_HouseInfo>, IGetDetail_Listing_Estate_TypeInfo_HouseInfo
    {
        public GetDetail_Listing_Estate_TypeInfo_HouseInfo()
        {
        }

        public virtual global::System.Boolean Equals(GetDetail_Listing_Estate_TypeInfo_HouseInfo? other)
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

            return Equals((GetDetail_Listing_Estate_TypeInfo_HouseInfo)obj);
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
