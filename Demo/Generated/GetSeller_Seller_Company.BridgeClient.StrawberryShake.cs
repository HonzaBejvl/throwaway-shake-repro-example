﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetSeller_Seller_Company : global::System.IEquatable<GetSeller_Seller_Company>, IGetSeller_Seller_Company
    {
        public GetSeller_Seller_Company(global::System.String name, global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_1 photo, global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Headquarters headquarters)
        {
            Name = name;
            Photo = photo;
            Headquarters = headquarters;
        }

        public global::System.String Name { get; }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_1 Photo { get; }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Headquarters Headquarters { get; }

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

            return Equals((GetSeller_Seller_Company)obj);
        }

        public global::System.Boolean Equals(GetSeller_Seller_Company? other)
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

            return (Name.Equals(other.Name)) && Photo.Equals(other.Photo) && Headquarters.Equals(other.Headquarters);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Name.GetHashCode();
                hash ^= 397 * Photo.GetHashCode();
                hash ^= 397 * Headquarters.GetHashCode();
                return hash;
            }
        }
    }
}
