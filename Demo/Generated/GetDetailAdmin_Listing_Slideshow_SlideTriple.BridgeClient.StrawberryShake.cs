﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetDetailAdmin_Listing_Slideshow_SlideTriple : global::System.IEquatable<GetDetailAdmin_Listing_Slideshow_SlideTriple>, IGetDetailAdmin_Listing_Slideshow_SlideTriple
    {
        public GetDetailAdmin_Listing_Slideshow_SlideTriple(global::System.Int32 index, global::Logic.Graphql.Generated.SlideLayout layout, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemOne_1 itemOne, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemTwo_1 itemTwo, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemThree itemThree)
        {
            Index = index;
            Layout = layout;
            ItemOne = itemOne;
            ItemTwo = itemTwo;
            ItemThree = itemThree;
        }

        public global::System.Int32 Index { get; }

        public global::Logic.Graphql.Generated.SlideLayout Layout { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemOne_1 ItemOne { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemTwo_1 ItemTwo { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemThree ItemThree { get; }

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

            return Equals((GetDetailAdmin_Listing_Slideshow_SlideTriple)obj);
        }

        public global::System.Boolean Equals(GetDetailAdmin_Listing_Slideshow_SlideTriple? other)
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

            return (Index == other.Index) && Layout.Equals(other.Layout) && ItemOne.Equals(other.ItemOne) && ItemTwo.Equals(other.ItemTwo) && ItemThree.Equals(other.ItemThree);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Index.GetHashCode();
                hash ^= 397 * Layout.GetHashCode();
                hash ^= 397 * ItemOne.GetHashCode();
                hash ^= 397 * ItemTwo.GetHashCode();
                hash ^= 397 * ItemThree.GetHashCode();
                return hash;
            }
        }
    }
}