﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    ///<summary>Adresa v detailu nabídky - položky nabývají hodnoty null v případě rozostření adresy</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class AddressListingData
    {
        public AddressListingData(global::System.String __typename, global::System.Double? lat = default !, global::System.Double? lng = default !, global::System.String? cityName = default !, global::System.String? streetName = default !, global::System.Int32? ruianCode = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Lat = lat;
            Lng = lng;
            CityName = cityName;
            StreetName = streetName;
            RuianCode = ruianCode;
        }

        public global::System.String __typename { get; }

        public global::System.Double? Lat { get; }

        public global::System.Double? Lng { get; }

        public global::System.String? CityName { get; }

        public global::System.String? StreetName { get; }

        public global::System.Int32? RuianCode { get; }
    }
}
