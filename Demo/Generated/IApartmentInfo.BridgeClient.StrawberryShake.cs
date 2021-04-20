﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Doplnující informace pro byty
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public interface IApartmentInfo
    {
        public global::Logic.Graphql.Generated.ApartmentType ApartmentType { get; }

        public global::System.Double UsableArea { get; }

        public global::Logic.Graphql.Generated.Material Material { get; }

        public global::Logic.Graphql.Generated.EnergyEfficiency EnergyEfficiency { get; }

        public global::Logic.Graphql.Generated.EnergyCertificate EnergyCertificate { get; }

        public global::Logic.Graphql.Generated.Condition Condition { get; }

        public global::System.Double? BalconyArea { get; }

        public global::System.Double? TerraceArea { get; }

        public global::System.Double? LoggiaArea { get; }

        public global::System.Double? CellarArea { get; }

        public global::System.Double CeilingHeight { get; }

        public global::System.Double? PoolArea { get; }

        public global::System.Int32 AcceptanceYear { get; }

        public global::System.Int32 ConstructionYear { get; }

        public global::System.Int32? ReconstructionYear { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Amenity>? Amenities { get; }

        public global::System.Int32 RoomCount { get; }

        public global::System.Int32 FloorNumber { get; }

        public global::System.String ApartmentNumber { get; }

        public global::Logic.Graphql.Generated.Placement Placement { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.ApartmentSpecialType>? SpecialClass { get; }
    }
}
