﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Aukce - nabídka typu aukce
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetCard_Listing_Auction : global::System.IEquatable<GetCard_Listing_Auction>, IGetCard_Listing_Auction
    {
        public GetCard_Listing_Auction(global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_StartingPrice startingPrice, global::Logic.Graphql.Generated.ServiceType serviceType, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Estate estate, global::System.String listingId, global::System.String? title, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow> slideshow, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Photos> photos)
        {
            StartingPrice = startingPrice;
            ServiceType = serviceType;
            Estate = estate;
            ListingId = listingId;
            Title = title;
            Slideshow = slideshow;
            Photos = photos;
        }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_StartingPrice StartingPrice { get; }

        public global::Logic.Graphql.Generated.ServiceType ServiceType { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Estate Estate { get; }

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

            return Equals((GetCard_Listing_Auction)obj);
        }

        public global::System.Boolean Equals(GetCard_Listing_Auction? other)
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

            return (StartingPrice.Equals(other.StartingPrice)) && ServiceType.Equals(other.ServiceType) && Estate.Equals(other.Estate) && ListingId.Equals(other.ListingId) && ((Title is null && other.Title is null) || Title != null && Title.Equals(other.Title)) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Slideshow, other.Slideshow) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Photos, other.Photos);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * StartingPrice.GetHashCode();
                hash ^= 397 * ServiceType.GetHashCode();
                hash ^= 397 * Estate.GetHashCode();
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
