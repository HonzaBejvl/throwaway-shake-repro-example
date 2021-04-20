﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Adresa - plné zobrazení adresy
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingEdit_ListingEdit_Subject_Estate_FullAddress_Address : global::System.IEquatable<ListingEdit_ListingEdit_Subject_Estate_FullAddress_Address>, IListingEdit_ListingEdit_Subject_Estate_FullAddress_Address
    {
        public ListingEdit_ListingEdit_Subject_Estate_FullAddress_Address(global::System.Double lat, global::System.Double lng, global::System.String cityName, global::System.String? streetName, global::System.Int32 ruianCode)
        {
            Lat = lat;
            Lng = lng;
            CityName = cityName;
            StreetName = streetName;
            RuianCode = ruianCode;
        }

        public global::System.Double Lat { get; }

        public global::System.Double Lng { get; }

        public global::System.String CityName { get; }

        public global::System.String? StreetName { get; }

        public global::System.Int32 RuianCode { get; }

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

            return Equals((ListingEdit_ListingEdit_Subject_Estate_FullAddress_Address)obj);
        }

        public global::System.Boolean Equals(ListingEdit_ListingEdit_Subject_Estate_FullAddress_Address? other)
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

            return (Lat == other.Lat) && Lng == other.Lng && CityName.Equals(other.CityName) && ((StreetName is null && other.StreetName is null) || StreetName != null && StreetName.Equals(other.StreetName)) && RuianCode == other.RuianCode;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Lat.GetHashCode();
                hash ^= 397 * Lng.GetHashCode();
                hash ^= 397 * CityName.GetHashCode();
                if (StreetName != null)
                {
                    hash ^= 397 * StreetName.GetHashCode();
                }

                hash ^= 397 * RuianCode.GetHashCode();
                return hash;
            }
        }
    }
}
