﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class SlideLayoutSerializer : global::StrawberryShake.Serialization.IInputValueFormatter, global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, SlideLayout>
    {
        public global::System.String TypeName => "SlideLayout";
        public SlideLayout Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
            "LEFT" => SlideLayout.Left, "RIGHT" => SlideLayout.Right, "EVEN" => SlideLayout.Even, _ => throw new global::StrawberryShake.GraphQLClientException()}

            ;
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
            SlideLayout.Left => "LEFT", SlideLayout.Right => "RIGHT", SlideLayout.Even => "EVEN", _ => throw new global::StrawberryShake.GraphQLClientException()}

            ;
        }
    }
}
