﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    ///<summary>Doplnující informace pro pozemky</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class LandInfoData : IEstateTypeInfoData
    {
        public LandInfoData(global::System.String __typename, global::Logic.Graphql.Generated.LandType? landlType = default !, global::System.Double? landArea = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            LandlType = landlType;
            LandArea = landArea;
        }

        public global::System.String __typename { get; }

        public global::Logic.Graphql.Generated.LandType? LandlType { get; }

        public global::System.Double? LandArea { get; }
    }
}
