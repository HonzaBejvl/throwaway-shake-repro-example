﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingEdit_ListingEdit_Subject_Slideshow_SlideDouble : global::System.IEquatable<ListingEdit_ListingEdit_Subject_Slideshow_SlideDouble>, IListingEdit_ListingEdit_Subject_Slideshow_SlideDouble
    {
        public ListingEdit_ListingEdit_Subject_Slideshow_SlideDouble(global::System.Int32 index, global::Logic.Graphql.Generated.SlideLayout layout, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemOne itemOne, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemTwo itemTwo)
        {
            Index = index;
            Layout = layout;
            ItemOne = itemOne;
            ItemTwo = itemTwo;
        }

        public global::System.Int32 Index { get; }

        public global::Logic.Graphql.Generated.SlideLayout Layout { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemOne ItemOne { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_ItemTwo ItemTwo { get; }

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

            return Equals((ListingEdit_ListingEdit_Subject_Slideshow_SlideDouble)obj);
        }

        public global::System.Boolean Equals(ListingEdit_ListingEdit_Subject_Slideshow_SlideDouble? other)
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

            return (Index == other.Index) && Layout.Equals(other.Layout) && ItemOne.Equals(other.ItemOne) && ItemTwo.Equals(other.ItemTwo);
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
                return hash;
            }
        }
    }
}
