﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Aukce - nabídka typu aukce
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetDetail_Listing_Auction : global::System.IEquatable<GetDetail_Listing_Auction>, IGetDetail_Listing_Auction
    {
        public GetDetail_Listing_Auction(global::Logic.Graphql.Generated.IGetDetail_Listing_Estate estate)
        {
            Estate = estate;
        }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Estate Estate { get; }

        public virtual global::System.Boolean Equals(GetDetail_Listing_Auction? other)
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

            return (Estate.Equals(other.Estate));
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

            return Equals((GetDetail_Listing_Auction)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Estate.GetHashCode();
                return hash;
            }
        }
    }
}
