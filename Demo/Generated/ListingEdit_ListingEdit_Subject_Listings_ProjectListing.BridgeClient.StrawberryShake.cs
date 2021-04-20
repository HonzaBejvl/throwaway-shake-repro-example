﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingEdit_ListingEdit_Subject_Listings_ProjectListing : global::System.IEquatable<ListingEdit_ListingEdit_Subject_Listings_ProjectListing>, IListingEdit_ListingEdit_Subject_Listings_ProjectListing
    {
        public ListingEdit_ListingEdit_Subject_Listings_ProjectListing(global::System.Boolean satisfiesFilter, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Listings_Listing listing)
        {
            SatisfiesFilter = satisfiesFilter;
            Listing = listing;
        }

        public global::System.Boolean SatisfiesFilter { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Listings_Listing Listing { get; }

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

            return Equals((ListingEdit_ListingEdit_Subject_Listings_ProjectListing)obj);
        }

        public global::System.Boolean Equals(ListingEdit_ListingEdit_Subject_Listings_ProjectListing? other)
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

            return (SatisfiesFilter == other.SatisfiesFilter) && Listing.Equals(other.Listing);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * SatisfiesFilter.GetHashCode();
                hash ^= 397 * Listing.GetHashCode();
                return hash;
            }
        }
    }
}
