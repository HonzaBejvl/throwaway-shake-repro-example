﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Cena - informace o ceně
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public interface IPrice
    {
        public global::System.Double Value { get; }

        public global::Logic.Graphql.Generated.Currency OriginalCurrency { get; }

        public global::Logic.Graphql.Generated.PricePeriod Period { get; }

        public global::Logic.Graphql.Generated.PriceUnit Unit { get; }
    }
}