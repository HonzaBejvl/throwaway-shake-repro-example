﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetDetail_Listing_Project : global::System.IEquatable<GetDetail_Listing_Project>, IGetDetail_Listing_Project
    {
        public GetDetail_Listing_Project(global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_2 seller, global::System.Int32 listingCount, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetail_Listing_Listings> listings, global::System.String listingId, global::System.String? title, global::System.String? description, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow> slideshow, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Photos> photos, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetail_Listing_Videos> videos, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetail_Listing_FloorPlans> floorPlans)
        {
            Seller = seller;
            ListingCount = listingCount;
            Listings = listings;
            ListingId = listingId;
            Title = title;
            Description = description;
            Slideshow = slideshow;
            Photos = photos;
            Videos = videos;
            FloorPlans = floorPlans;
        }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_2 Seller { get; }

        public global::System.Int32 ListingCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetail_Listing_Listings> Listings { get; }

        public global::System.String ListingId { get; }

        public global::System.String? Title { get; }

        public global::System.String? Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow> Slideshow { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Photos> Photos { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetail_Listing_Videos> Videos { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetail_Listing_FloorPlans> FloorPlans { get; }

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

            return Equals((GetDetail_Listing_Project)obj);
        }

        public global::System.Boolean Equals(GetDetail_Listing_Project? other)
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

            return (Seller.Equals(other.Seller)) && ListingCount == other.ListingCount && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Listings, other.Listings) && ListingId.Equals(other.ListingId) && ((Title is null && other.Title is null) || Title != null && Title.Equals(other.Title)) && ((Description is null && other.Description is null) || Description != null && Description.Equals(other.Description)) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Slideshow, other.Slideshow) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Photos, other.Photos) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Videos, other.Videos) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(FloorPlans, other.FloorPlans);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Seller.GetHashCode();
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

                if (Description != null)
                {
                    hash ^= 397 * Description.GetHashCode();
                }

                foreach (var Slideshow_elm in Slideshow)
                {
                    hash ^= 397 * Slideshow_elm.GetHashCode();
                }

                foreach (var Photos_elm in Photos)
                {
                    hash ^= 397 * Photos_elm.GetHashCode();
                }

                foreach (var Videos_elm in Videos)
                {
                    hash ^= 397 * Videos_elm.GetHashCode();
                }

                foreach (var FloorPlans_elm in FloorPlans)
                {
                    hash ^= 397 * FloorPlans_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}