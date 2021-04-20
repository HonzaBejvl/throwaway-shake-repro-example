﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Root type pro write operace Nemovizor API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddResult : global::System.IEquatable<ListingAddResult>, IListingAddResult
    {
        public ListingAddResult(global::Logic.Graphql.Generated.IListingAdd_ListingAdd listingAdd)
        {
            ListingAdd = listingAdd;
        }

        /// <summary>
        /// Přidání Listing.
        /// </summary>
        public global::Logic.Graphql.Generated.IListingAdd_ListingAdd ListingAdd { get; }

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

            return Equals((ListingAddResult)obj);
        }

        public global::System.Boolean Equals(ListingAddResult? other)
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

            return (ListingAdd.Equals(other.ListingAdd));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * ListingAdd.GetHashCode();
                return hash;
            }
        }
    }
}
