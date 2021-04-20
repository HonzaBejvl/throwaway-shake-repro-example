﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingSortSerializer : global::StrawberryShake.Serialization.IInputValueFormatter, global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, ListingSort>
    {
        public global::System.String TypeName => "ListingSort";
        public ListingSort Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
            "RELEVANCE" => ListingSort.Relevance, "NEWEST" => ListingSort.Newest, "CHEAPEST" => ListingSort.Cheapest, "MOST_EXPENSIVE" => ListingSort.MostExpensive, _ => throw new global::StrawberryShake.GraphQLClientException()}

            ;
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
            ListingSort.Relevance => "RELEVANCE", ListingSort.Newest => "NEWEST", ListingSort.Cheapest => "CHEAPEST", ListingSort.MostExpensive => "MOST_EXPENSIVE", _ => throw new global::StrawberryShake.GraphQLClientException()}

            ;
        }
    }
}
