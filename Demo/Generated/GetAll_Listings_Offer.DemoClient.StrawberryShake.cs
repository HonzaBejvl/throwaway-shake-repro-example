﻿// <auto-generated/>
#nullable enable

namespace Demo.Graphql
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetAll_Listings_Offer : global::System.IEquatable<GetAll_Listings_Offer>, IGetAll_Listings_Offer
    {
        public GetAll_Listings_Offer(global::Demo.Graphql.ServiceType serviceType)
        {
            ServiceType = serviceType;
        }

        public global::Demo.Graphql.ServiceType ServiceType { get; }

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

            return Equals((GetAll_Listings_Offer)obj);
        }

        public global::System.Boolean Equals(GetAll_Listings_Offer? other)
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

            return (ServiceType.Equals(other.ServiceType));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * ServiceType.GetHashCode();
                return hash;
            }
        }
    }
}