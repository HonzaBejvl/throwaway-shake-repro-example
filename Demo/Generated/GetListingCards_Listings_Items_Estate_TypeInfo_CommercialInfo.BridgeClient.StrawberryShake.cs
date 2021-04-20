﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Doplnující informace pro komerční prostory
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetListingCards_Listings_Items_Estate_TypeInfo_CommercialInfo : global::System.IEquatable<GetListingCards_Listings_Items_Estate_TypeInfo_CommercialInfo>, IGetListingCards_Listings_Items_Estate_TypeInfo_CommercialInfo
    {
        public GetListingCards_Listings_Items_Estate_TypeInfo_CommercialInfo(global::Logic.Graphql.Generated.CommercialType commercialType, global::Logic.Graphql.Generated.EnergyEfficiency energyEfficiency, global::Logic.Graphql.Generated.EnergyCertificate energyCertificate, global::Logic.Graphql.Generated.Condition condition, global::Logic.Graphql.Generated.Material material, global::Logic.Graphql.Generated.Placement placement, global::System.Int32 roomCount, global::System.Double ceilingHeight, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Amenity>? amenities, global::System.Double usableArea, global::System.Double? balconyArea, global::System.Double? terraceArea, global::System.Double? loggiaArea, global::System.Double? cellarArea, global::System.Double? poolArea, global::System.Int32 constructionYear, global::System.Int32 acceptanceYear, global::System.Int32? reconstructionYear, global::System.Double? storeArea, global::System.Double? officeArea, global::System.Double? warehouseArea, global::System.Double? productionArea)
        {
            CommercialType = commercialType;
            EnergyEfficiency = energyEfficiency;
            EnergyCertificate = energyCertificate;
            Condition = condition;
            Material = material;
            Placement = placement;
            RoomCount = roomCount;
            CeilingHeight = ceilingHeight;
            Amenities = amenities;
            UsableArea = usableArea;
            BalconyArea = balconyArea;
            TerraceArea = terraceArea;
            LoggiaArea = loggiaArea;
            CellarArea = cellarArea;
            PoolArea = poolArea;
            ConstructionYear = constructionYear;
            AcceptanceYear = acceptanceYear;
            ReconstructionYear = reconstructionYear;
            StoreArea = storeArea;
            OfficeArea = officeArea;
            WarehouseArea = warehouseArea;
            ProductionArea = productionArea;
        }

        public global::Logic.Graphql.Generated.CommercialType CommercialType { get; }

        public global::Logic.Graphql.Generated.EnergyEfficiency EnergyEfficiency { get; }

        public global::Logic.Graphql.Generated.EnergyCertificate EnergyCertificate { get; }

        public global::Logic.Graphql.Generated.Condition Condition { get; }

        public global::Logic.Graphql.Generated.Material Material { get; }

        public global::Logic.Graphql.Generated.Placement Placement { get; }

        public global::System.Int32 RoomCount { get; }

        public global::System.Double CeilingHeight { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Amenity>? Amenities { get; }

        public global::System.Double UsableArea { get; }

        public global::System.Double? BalconyArea { get; }

        public global::System.Double? TerraceArea { get; }

        public global::System.Double? LoggiaArea { get; }

        public global::System.Double? CellarArea { get; }

        public global::System.Double? PoolArea { get; }

        public global::System.Int32 ConstructionYear { get; }

        public global::System.Int32 AcceptanceYear { get; }

        public global::System.Int32? ReconstructionYear { get; }

        public global::System.Double? StoreArea { get; }

        public global::System.Double? OfficeArea { get; }

        public global::System.Double? WarehouseArea { get; }

        public global::System.Double? ProductionArea { get; }

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

            return Equals((GetListingCards_Listings_Items_Estate_TypeInfo_CommercialInfo)obj);
        }

        public global::System.Boolean Equals(GetListingCards_Listings_Items_Estate_TypeInfo_CommercialInfo? other)
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

            return (CommercialType.Equals(other.CommercialType)) && EnergyEfficiency.Equals(other.EnergyEfficiency) && EnergyCertificate.Equals(other.EnergyCertificate) && Condition.Equals(other.Condition) && Material.Equals(other.Material) && Placement.Equals(other.Placement) && RoomCount == other.RoomCount && CeilingHeight == other.CeilingHeight && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Amenities, other.Amenities) && UsableArea == other.UsableArea && BalconyArea == other.BalconyArea && TerraceArea == other.TerraceArea && LoggiaArea == other.LoggiaArea && CellarArea == other.CellarArea && PoolArea == other.PoolArea && ConstructionYear == other.ConstructionYear && AcceptanceYear == other.AcceptanceYear && ReconstructionYear == other.ReconstructionYear && StoreArea == other.StoreArea && OfficeArea == other.OfficeArea && WarehouseArea == other.WarehouseArea && ProductionArea == other.ProductionArea;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * CommercialType.GetHashCode();
                hash ^= 397 * EnergyEfficiency.GetHashCode();
                hash ^= 397 * EnergyCertificate.GetHashCode();
                hash ^= 397 * Condition.GetHashCode();
                hash ^= 397 * Material.GetHashCode();
                hash ^= 397 * Placement.GetHashCode();
                hash ^= 397 * RoomCount.GetHashCode();
                hash ^= 397 * CeilingHeight.GetHashCode();
                if (Amenities != null)
                {
                    foreach (var Amenities_elm in Amenities)
                    {
                        hash ^= 397 * Amenities_elm.GetHashCode();
                    }
                }

                hash ^= 397 * UsableArea.GetHashCode();
                if (BalconyArea != null)
                {
                    hash ^= 397 * BalconyArea.GetHashCode();
                }

                if (TerraceArea != null)
                {
                    hash ^= 397 * TerraceArea.GetHashCode();
                }

                if (LoggiaArea != null)
                {
                    hash ^= 397 * LoggiaArea.GetHashCode();
                }

                if (CellarArea != null)
                {
                    hash ^= 397 * CellarArea.GetHashCode();
                }

                if (PoolArea != null)
                {
                    hash ^= 397 * PoolArea.GetHashCode();
                }

                hash ^= 397 * ConstructionYear.GetHashCode();
                hash ^= 397 * AcceptanceYear.GetHashCode();
                if (ReconstructionYear != null)
                {
                    hash ^= 397 * ReconstructionYear.GetHashCode();
                }

                if (StoreArea != null)
                {
                    hash ^= 397 * StoreArea.GetHashCode();
                }

                if (OfficeArea != null)
                {
                    hash ^= 397 * OfficeArea.GetHashCode();
                }

                if (WarehouseArea != null)
                {
                    hash ^= 397 * WarehouseArea.GetHashCode();
                }

                if (ProductionArea != null)
                {
                    hash ^= 397 * ProductionArea.GetHashCode();
                }

                return hash;
            }
        }
    }
}
