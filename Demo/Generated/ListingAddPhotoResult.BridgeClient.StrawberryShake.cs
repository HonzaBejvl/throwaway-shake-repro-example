﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Root type pro write operace Nemovizor API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddPhotoResult : global::System.IEquatable<ListingAddPhotoResult>, IListingAddPhotoResult
    {
        public ListingAddPhotoResult(global::Logic.Graphql.Generated.IListingAddPhoto_ListingAddPhoto listingAddPhoto)
        {
            ListingAddPhoto = listingAddPhoto;
        }

        /// <summary>
        /// Přidání Photo k Listing.
        /// 
        /// - Url fotky musí být url již nahraného souboru na Nemovizor file storage (viz Query::uploadLink).
        /// </summary>
        public global::Logic.Graphql.Generated.IListingAddPhoto_ListingAddPhoto ListingAddPhoto { get; }

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

            return Equals((ListingAddPhotoResult)obj);
        }

        public global::System.Boolean Equals(ListingAddPhotoResult? other)
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

            return (ListingAddPhoto.Equals(other.ListingAddPhoto));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * ListingAddPhoto.GetHashCode();
                return hash;
            }
        }
    }
}
