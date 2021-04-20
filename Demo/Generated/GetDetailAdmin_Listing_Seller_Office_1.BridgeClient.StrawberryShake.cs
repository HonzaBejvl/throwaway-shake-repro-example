﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetDetailAdmin_Listing_Seller_Office_1 : global::System.IEquatable<GetDetailAdmin_Listing_Seller_Office_1>, IGetDetailAdmin_Listing_Seller_Office_1
    {
        public GetDetailAdmin_Listing_Seller_Office_1(global::System.String sellerId, global::System.String name, global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Photo_2 photo, global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Company_4 company, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Subordinates_2> subordinates)
        {
            SellerId = sellerId;
            Name = name;
            Photo = photo;
            Company = company;
            Subordinates = subordinates;
        }

        public global::System.String SellerId { get; }

        public global::System.String Name { get; }

        public global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Photo_2 Photo { get; }

        public global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Company_4 Company { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetDetailAdmin_Listing_Seller_Subordinates_2> Subordinates { get; }

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

            return Equals((GetDetailAdmin_Listing_Seller_Office_1)obj);
        }

        public global::System.Boolean Equals(GetDetailAdmin_Listing_Seller_Office_1? other)
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

            return (SellerId.Equals(other.SellerId)) && Name.Equals(other.Name) && Photo.Equals(other.Photo) && Company.Equals(other.Company) && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Subordinates, other.Subordinates);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * SellerId.GetHashCode();
                hash ^= 397 * Name.GetHashCode();
                hash ^= 397 * Photo.GetHashCode();
                hash ^= 397 * Company.GetHashCode();
                foreach (var Subordinates_elm in Subordinates)
                {
                    hash ^= 397 * Subordinates_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}
