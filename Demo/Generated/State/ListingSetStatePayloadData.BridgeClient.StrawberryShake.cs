﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    ///<summary>Výsledek operace změny stavu nabídky.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingSetStatePayloadData
    {
        public ListingSetStatePayloadData(global::System.String __typename, global::Logic.Graphql.Generated.State.IListingData? subject = default !, global::Logic.Graphql.Generated.ListingState? oldState = default !, global::Logic.Graphql.Generated.ListingState? newState = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Subject = subject;
            OldState = oldState;
            NewState = newState;
        }

        public global::System.String __typename { get; }

        public global::Logic.Graphql.Generated.State.IListingData? Subject { get; }

        public global::Logic.Graphql.Generated.ListingState? OldState { get; }

        public global::Logic.Graphql.Generated.ListingState? NewState { get; }
    }
}