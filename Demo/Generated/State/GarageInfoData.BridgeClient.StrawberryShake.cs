﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    ///<summary>Doplnující informace pro garáže a ostatní nemovitosti</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GarageInfoData : IEstateTypeInfoData
    {
        public GarageInfoData(global::System.String __typename, global::Logic.Graphql.Generated.GarageType? garageType = default !, global::System.Double? usableArea = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            GarageType = garageType;
            UsableArea = usableArea;
        }

        public global::System.String __typename { get; }

        public global::Logic.Graphql.Generated.GarageType? GarageType { get; }

        public global::System.Double? UsableArea { get; }
    }
}