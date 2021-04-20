﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Gps type - latitude and longitude.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetAllSearchResults_Search_Viewport_Bottom_right_Gps : global::System.IEquatable<GetAllSearchResults_Search_Viewport_Bottom_right_Gps>, IGetAllSearchResults_Search_Viewport_Bottom_right_Gps
    {
        public GetAllSearchResults_Search_Viewport_Bottom_right_Gps(global::System.Double lat, global::System.Double lng)
        {
            Lat = lat;
            Lng = lng;
        }

        public global::System.Double Lat { get; }

        public global::System.Double Lng { get; }

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

            return Equals((GetAllSearchResults_Search_Viewport_Bottom_right_Gps)obj);
        }

        public global::System.Boolean Equals(GetAllSearchResults_Search_Viewport_Bottom_right_Gps? other)
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

            return (Lat == other.Lat) && Lng == other.Lng;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Lat.GetHashCode();
                hash ^= 397 * Lng.GetHashCode();
                return hash;
            }
        }
    }
}
