﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Root type pro write operace Nemovizor API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingEditResult : global::System.IEquatable<ListingEditResult>, IListingEditResult
    {
        public ListingEditResult(global::Logic.Graphql.Generated.IListingEdit_ListingEdit listingEdit)
        {
            ListingEdit = listingEdit;
        }

        /// <summary>
        /// Úprava Listing.
        /// </summary>
        public global::Logic.Graphql.Generated.IListingEdit_ListingEdit ListingEdit { get; }

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

            return Equals((ListingEditResult)obj);
        }

        public global::System.Boolean Equals(ListingEditResult? other)
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

            return (ListingEdit.Equals(other.ListingEdit));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * ListingEdit.GetHashCode();
                return hash;
            }
        }
    }
}
