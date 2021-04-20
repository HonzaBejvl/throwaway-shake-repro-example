﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Root type pro read operace nemovizor API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetAllSearchResultsResult : global::System.IEquatable<GetAllSearchResultsResult>, IGetAllSearchResultsResult
    {
        public GetAllSearchResultsResult(global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetAllSearchResults_Search> search)
        {
            Search = search;
        }

        /// <summary>
        /// Vyhledávání v obsahu nemovizoru
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetAllSearchResults_Search> Search { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetAllSearchResultsResult)obj);
        }

        public global::System.Boolean Equals(GetAllSearchResultsResult? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Search, other.Search));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                foreach (var Search_elm in Search)
                {
                    hash ^= 397 * Search_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}
