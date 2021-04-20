﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class CommercialTypeSerializer : global::StrawberryShake.Serialization.IInputValueFormatter, global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, CommercialType>
    {
        public global::System.String TypeName => "CommercialType";
        public CommercialType Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
            "COMM_OFFICE" => CommercialType.CommOffice, "COMM_VIRTUAL_OFFICE" => CommercialType.CommVirtualOffice, "COMM_WAREHOUSE" => CommercialType.CommWarehouse, "COMM_PRODUCTION" => CommercialType.CommProduction, "COMM_STORE" => CommercialType.CommStore, "COMM_ACCOMMODATION" => CommercialType.CommAccommodation, "COMM_CATERING" => CommercialType.CommCatering, "COMM_AGRICULTURAL" => CommercialType.CommAgricultural, "COMM_APARTMENTS" => CommercialType.CommApartments, "OTHER" => CommercialType.Other, _ => throw new global::StrawberryShake.GraphQLClientException()}

            ;
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
            CommercialType.CommOffice => "COMM_OFFICE", CommercialType.CommVirtualOffice => "COMM_VIRTUAL_OFFICE", CommercialType.CommWarehouse => "COMM_WAREHOUSE", CommercialType.CommProduction => "COMM_PRODUCTION", CommercialType.CommStore => "COMM_STORE", CommercialType.CommAccommodation => "COMM_ACCOMMODATION", CommercialType.CommCatering => "COMM_CATERING", CommercialType.CommAgricultural => "COMM_AGRICULTURAL", CommercialType.CommApartments => "COMM_APARTMENTS", CommercialType.Other => "OTHER", _ => throw new global::StrawberryShake.GraphQLClientException()}

            ;
        }
    }
}