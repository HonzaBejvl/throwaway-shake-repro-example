﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Root type pro read operace nemovizor API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public interface IGetCardResult
    {
        /// <summary>
        /// Vyhledání inzerátu dle ID
        /// 
        /// Vrací null pokud inzerát neexistuje nebo pokud klient nemá práva na jeho zobrazení.
        /// </summary>
        public global::Logic.Graphql.Generated.IGetCard_Listing Listing { get; }
    }
}
