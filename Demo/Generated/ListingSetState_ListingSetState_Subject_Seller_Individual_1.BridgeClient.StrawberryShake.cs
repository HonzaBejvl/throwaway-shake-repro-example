﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingSetState_ListingSetState_Subject_Seller_Individual_1 : global::System.IEquatable<ListingSetState_ListingSetState_Subject_Seller_Individual_1>, IListingSetState_ListingSetState_Subject_Seller_Individual_1
    {
        public ListingSetState_ListingSetState_Subject_Seller_Individual_1(global::System.String sellerId)
        {
            SellerId = sellerId;
        }

        public global::System.String SellerId { get; }

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

            return Equals((ListingSetState_ListingSetState_Subject_Seller_Individual_1)obj);
        }

        public global::System.Boolean Equals(ListingSetState_ListingSetState_Subject_Seller_Individual_1? other)
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

            return (SellerId.Equals(other.SellerId));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * SellerId.GetHashCode();
                return hash;
            }
        }
    }
}
