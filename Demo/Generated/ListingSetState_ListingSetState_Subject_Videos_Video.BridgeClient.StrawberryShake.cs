﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingSetState_ListingSetState_Subject_Videos_Video : global::System.IEquatable<ListingSetState_ListingSetState_Subject_Videos_Video>, IListingSetState_ListingSetState_Subject_Videos_Video
    {
        public ListingSetState_ListingSetState_Subject_Videos_Video(global::System.Uri url)
        {
            Url = url;
        }

        public global::System.Uri Url { get; }

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

            return Equals((ListingSetState_ListingSetState_Subject_Videos_Video)obj);
        }

        public global::System.Boolean Equals(ListingSetState_ListingSetState_Subject_Videos_Video? other)
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

            return (Url.Equals(other.Url));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Url.GetHashCode();
                return hash;
            }
        }
    }
}
