﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    ///<summary>Cena - informace o ceně</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class PriceData
    {
        public PriceData(global::System.String __typename, global::System.Double? @value = default !, global::Logic.Graphql.Generated.Currency? originalCurrency = default !, global::Logic.Graphql.Generated.PricePeriod? period = default !, global::Logic.Graphql.Generated.PriceUnit? unit = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Value = @value;
            OriginalCurrency = originalCurrency;
            Period = period;
            Unit = unit;
        }

        public global::System.String __typename { get; }

        public global::System.Double? Value { get; }

        public global::Logic.Graphql.Generated.Currency? OriginalCurrency { get; }

        public global::Logic.Graphql.Generated.PricePeriod? Period { get; }

        public global::Logic.Graphql.Generated.PriceUnit? Unit { get; }
    }
}