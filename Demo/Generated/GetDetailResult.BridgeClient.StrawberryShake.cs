﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Root type pro read operace nemovizor API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetDetailResult : global::System.IEquatable<GetDetailResult>, IGetDetailResult
    {
        public GetDetailResult(global::Logic.Graphql.Generated.IGetDetail_Listing listing)
        {
            Listing = listing;
        }

        /// <summary>
        /// Vyhledání inzerátu dle ID
        /// </summary>
        public global::Logic.Graphql.Generated.IGetDetail_Listing Listing { get; }

        public virtual global::System.Boolean Equals(GetDetailResult? other)
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

            return (Listing.Equals(other.Listing));
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

            return Equals((GetDetailResult)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Listing.GetHashCode();
                return hash;
            }
        }
    }
}
