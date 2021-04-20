﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAdd_ListingAdd_Result_Seller_Company_Company_1 : global::System.IEquatable<ListingAdd_ListingAdd_Result_Seller_Company_Company_1>, IListingAdd_ListingAdd_Result_Seller_Company_Company_1
    {
        public ListingAdd_ListingAdd_Result_Seller_Company_Company_1(global::System.String name, global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_1 photo, global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Headquarters headquarters, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Subordinates_1> subordinates)
        {
            Name = name;
            Photo = photo;
            Headquarters = headquarters;
            Subordinates = subordinates;
        }

        public global::System.String Name { get; }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_1 Photo { get; }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Headquarters Headquarters { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Subordinates_1> Subordinates { get; }

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

            return Equals((ListingAdd_ListingAdd_Result_Seller_Company_Company_1)obj);
        }

        public global::System.Boolean Equals(ListingAdd_ListingAdd_Result_Seller_Company_Company_1? other)
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

            return (Name.Equals(other.Name)) && Photo.Equals(other.Photo) && Headquarters.Equals(other.Headquarters) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Subordinates, other.Subordinates);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Name.GetHashCode();
                hash ^= 397 * Photo.GetHashCode();
                hash ^= 397 * Headquarters.GetHashCode();
                foreach (var Subordinates_elm in Subordinates)
                {
                    hash ^= 397 * Subordinates_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}
