﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Doplnující informace pro domy
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingSetState_ListingSetState_Subject_Estate_TypeInfo_HouseInfo : global::System.IEquatable<ListingSetState_ListingSetState_Subject_Estate_TypeInfo_HouseInfo>, IListingSetState_ListingSetState_Subject_Estate_TypeInfo_HouseInfo
    {
        public ListingSetState_ListingSetState_Subject_Estate_TypeInfo_HouseInfo(global::Logic.Graphql.Generated.HouseType houseType, global::Logic.Graphql.Generated.EnergyEfficiency energyEfficiency, global::Logic.Graphql.Generated.EnergyCertificate energyCertificate, global::Logic.Graphql.Generated.Condition condition, global::Logic.Graphql.Generated.Material material, global::Logic.Graphql.Generated.Placement placement, global::System.Int32 roomCount, global::System.Double ceilingHeight, global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Amenity>? amenities, global::System.Double usableArea, global::System.Double? balconyArea, global::System.Double? terraceArea, global::System.Double? loggiaArea, global::System.Int32? reconstructionYear, global::System.Int32 constructionYear, global::System.Int32 acceptanceYear, global::System.Double? cellarArea, global::System.Double? poolArea, global::System.Double landArea)
        {
            HouseType = houseType;
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
            ReconstructionYear = reconstructionYear;
            ConstructionYear = constructionYear;
            AcceptanceYear = acceptanceYear;
            CellarArea = cellarArea;
            PoolArea = poolArea;
            LandArea = landArea;
        }

        public global::Logic.Graphql.Generated.HouseType HouseType { get; }

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

        public global::System.Int32? ReconstructionYear { get; }

        public global::System.Int32 ConstructionYear { get; }

        public global::System.Int32 AcceptanceYear { get; }

        public global::System.Double? CellarArea { get; }

        public global::System.Double? PoolArea { get; }

        public global::System.Double LandArea { get; }

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

            return Equals((ListingSetState_ListingSetState_Subject_Estate_TypeInfo_HouseInfo)obj);
        }

        public global::System.Boolean Equals(ListingSetState_ListingSetState_Subject_Estate_TypeInfo_HouseInfo? other)
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

            return (HouseType.Equals(other.HouseType)) && EnergyEfficiency.Equals(other.EnergyEfficiency) && EnergyCertificate.Equals(other.EnergyCertificate) && Condition.Equals(other.Condition) && Material.Equals(other.Material) && Placement.Equals(other.Placement) && RoomCount == other.RoomCount && CeilingHeight == other.CeilingHeight && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Amenities, other.Amenities) && UsableArea == other.UsableArea && BalconyArea == other.BalconyArea && TerraceArea == other.TerraceArea && LoggiaArea == other.LoggiaArea && ReconstructionYear == other.ReconstructionYear && ConstructionYear == other.ConstructionYear && AcceptanceYear == other.AcceptanceYear && CellarArea == other.CellarArea && PoolArea == other.PoolArea && LandArea == other.LandArea;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * HouseType.GetHashCode();
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

                if (ReconstructionYear != null)
                {
                    hash ^= 397 * ReconstructionYear.GetHashCode();
                }

                hash ^= 397 * ConstructionYear.GetHashCode();
                hash ^= 397 * AcceptanceYear.GetHashCode();
                if (CellarArea != null)
                {
                    hash ^= 397 * CellarArea.GetHashCode();
                }

                if (PoolArea != null)
                {
                    hash ^= 397 * PoolArea.GetHashCode();
                }

                hash ^= 397 * LandArea.GetHashCode();
                return hash;
            }
        }
    }
}
