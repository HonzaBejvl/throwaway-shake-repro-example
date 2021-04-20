﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetCard_Listing_Project : global::System.IEquatable<GetCard_Listing_Project>, IGetCard_Listing_Project
    {
        public GetCard_Listing_Project(global::System.Int32 listingCount, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Listings> listings, global::System.String listingId, global::System.String? title, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow> slideshow, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Photos> photos)
        {
            ListingCount = listingCount;
            Listings = listings;
            ListingId = listingId;
            Title = title;
            Slideshow = slideshow;
            Photos = photos;
        }

        public global::System.Int32 ListingCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Listings> Listings { get; }

        public global::System.String ListingId { get; }

        public global::System.String? Title { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow> Slideshow { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Photos> Photos { get; }

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

            return Equals((GetCard_Listing_Project)obj);
        }

        public global::System.Boolean Equals(GetCard_Listing_Project? other)
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

            return (ListingCount == other.ListingCount) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Listings, other.Listings) && ListingId.Equals(other.ListingId) && ((Title is null && other.Title is null) || Title != null && Title.Equals(other.Title)) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Slideshow, other.Slideshow) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Photos, other.Photos);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * ListingCount.GetHashCode();
                foreach (var Listings_elm in Listings)
                {
                    hash ^= 397 * Listings_elm.GetHashCode();
                }

                hash ^= 397 * ListingId.GetHashCode();
                if (Title != null)
                {
                    hash ^= 397 * Title.GetHashCode();
                }

                foreach (var Slideshow_elm in Slideshow)
                {
                    hash ^= 397 * Slideshow_elm.GetHashCode();
                }

                foreach (var Photos_elm in Photos)
                {
                    hash ^= 397 * Photos_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}
