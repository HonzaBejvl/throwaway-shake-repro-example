﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingEdit_ListingEdit_Subject_Slideshow_SlideSingle : global::System.IEquatable<ListingEdit_ListingEdit_Subject_Slideshow_SlideSingle>, IListingEdit_ListingEdit_Subject_Slideshow_SlideSingle
    {
        public ListingEdit_ListingEdit_Subject_Slideshow_SlideSingle(global::System.Int32 index, global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_Item item)
        {
            Index = index;
            Item = item;
        }

        public global::System.Int32 Index { get; }

        public global::Logic.Graphql.Generated.IGetListingCards_Listings_Items_Slideshow_Item Item { get; }

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

            return Equals((ListingEdit_ListingEdit_Subject_Slideshow_SlideSingle)obj);
        }

        public global::System.Boolean Equals(ListingEdit_ListingEdit_Subject_Slideshow_SlideSingle? other)
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

            return (Index == other.Index) && Item.Equals(other.Item);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Index.GetHashCode();
                hash ^= 397 * Item.GetHashCode();
                return hash;
            }
        }
    }
}