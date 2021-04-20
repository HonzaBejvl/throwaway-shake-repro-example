﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetCurrentViewerSeller_Viewer_Sellers_Seller_Office : global::System.IEquatable<GetCurrentViewerSeller_Viewer_Sellers_Seller_Office>, IGetCurrentViewerSeller_Viewer_Sellers_Seller_Office
    {
        public GetCurrentViewerSeller_Viewer_Sellers_Seller_Office(global::System.String sellerId, global::System.String name, global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_2 photo, global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Company_4 company)
        {
            SellerId = sellerId;
            Name = name;
            Photo = photo;
            Company = company;
        }

        public global::System.String SellerId { get; }

        public global::System.String Name { get; }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Photo_2 Photo { get; }

        public global::Logic.Graphql.Generated.IGetDetail_Listing_Seller_Company_4 Company { get; }

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

            return Equals((GetCurrentViewerSeller_Viewer_Sellers_Seller_Office)obj);
        }

        public global::System.Boolean Equals(GetCurrentViewerSeller_Viewer_Sellers_Seller_Office? other)
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

            return (SellerId.Equals(other.SellerId)) && Name.Equals(other.Name) && Photo.Equals(other.Photo) && Company.Equals(other.Company);
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
                return hash;
            }
        }
    }
}