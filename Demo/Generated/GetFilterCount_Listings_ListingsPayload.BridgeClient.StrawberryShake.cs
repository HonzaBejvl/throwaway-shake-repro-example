﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetFilterCount_Listings_ListingsPayload : global::System.IEquatable<GetFilterCount_Listings_ListingsPayload>, IGetFilterCount_Listings_ListingsPayload
    {
        public GetFilterCount_Listings_ListingsPayload(global::System.Int32 count)
        {
            Count = count;
        }

        public global::System.Int32 Count { get; }

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

            return Equals((GetFilterCount_Listings_ListingsPayload)obj);
        }

        public global::System.Boolean Equals(GetFilterCount_Listings_ListingsPayload? other)
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

            return (Count == other.Count);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Count.GetHashCode();
                return hash;
            }
        }
    }
}
