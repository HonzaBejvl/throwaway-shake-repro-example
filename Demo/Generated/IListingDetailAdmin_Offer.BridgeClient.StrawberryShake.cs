﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Standardní nabídka
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public interface IListingDetailAdmin_Offer : IOfferDetailAdmin, IHasListingId, IHasTitle, IHasDescription, IHasSlideshow, IHasPhotos, IHasVideos, IHasFloorPlans, IHasState
    {
        public global::System.DateTimeOffset Created { get; }

        public global::System.DateTimeOffset? Published { get; }

        public global::System.DateTimeOffset? Closed { get; }
    }
}
