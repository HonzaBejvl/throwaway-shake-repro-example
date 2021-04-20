﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Cena - informace o ceně
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAdd_ListingAdd_Result_Listings_Listing_Price_Price : global::System.IEquatable<ListingAdd_ListingAdd_Result_Listings_Listing_Price_Price>, IListingAdd_ListingAdd_Result_Listings_Listing_Price_Price
    {
        public ListingAdd_ListingAdd_Result_Listings_Listing_Price_Price(global::System.Double @value, global::Logic.Graphql.Generated.Currency originalCurrency, global::Logic.Graphql.Generated.PricePeriod period, global::Logic.Graphql.Generated.PriceUnit unit)
        {
            Value = @value;
            OriginalCurrency = originalCurrency;
            Period = period;
            Unit = unit;
        }

        public global::System.Double Value { get; }

        public global::Logic.Graphql.Generated.Currency OriginalCurrency { get; }

        public global::Logic.Graphql.Generated.PricePeriod Period { get; }

        public global::Logic.Graphql.Generated.PriceUnit Unit { get; }

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

            return Equals((ListingAdd_ListingAdd_Result_Listings_Listing_Price_Price)obj);
        }

        public global::System.Boolean Equals(ListingAdd_ListingAdd_Result_Listings_Listing_Price_Price? other)
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

            return (Value == other.Value) && OriginalCurrency.Equals(other.OriginalCurrency) && Period.Equals(other.Period) && Unit.Equals(other.Unit);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Value.GetHashCode();
                hash ^= 397 * OriginalCurrency.GetHashCode();
                hash ^= 397 * Period.GetHashCode();
                hash ^= 397 * Unit.GetHashCode();
                return hash;
            }
        }
    }
}