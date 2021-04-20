﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetCard GraphQL operation
    /// <code>
    /// query GetCard($id: ID!, $currency: Currency!) {
    ///   listing(listingId: $id) {
    ///     __typename
    ///     ... ListingCard
    ///   }
    /// }
    /// 
    /// fragment ListingCard on Listing {
    ///   ... OfferCard
    ///   ... AuctionCard
    ///   ... ProjectCard
    ///   ... HasListingId
    ///   ... HasTitle
    ///   ... HasSlideshow
    ///   ... HasPhotos
    /// }
    /// 
    /// fragment OfferCard on Offer {
    ///   price {
    ///     __typename
    ///     ... Price
    ///   }
    ///   serviceType
    ///   estate {
    ///     __typename
    ///     ... Estate
    ///   }
    /// }
    /// 
    /// fragment Price on Price {
    ///   value(currency: $currency)
    ///   originalCurrency
    ///   period
    ///   unit
    /// }
    /// 
    /// fragment Estate on Estate {
    ///   type
    ///   electricity
    ///   gas
    ///   water
    ///   heating
    ///   waste
    ///   road
    ///   natureProtection
    ///   connectivity
    ///   ... HasEstateTypeInfo
    ///   address {
    ///     __typename
    ///     ... AddressListing
    ///   }
    /// }
    /// 
    /// fragment HasEstateTypeInfo on Estate {
    ///   typeInfo {
    ///     __typename
    ///     ... ApartmentInfo
    ///     ... LandInfo
    ///     ... GarageInfo
    ///     ... HouseInfo
    ///     ... CommercialInfo
    ///   }
    /// }
    /// 
    /// fragment ApartmentInfo on ApartmentInfo {
    ///   apartmentType: type
    ///   usableArea
    ///   material
    ///   energyEfficiency
    ///   energyCertificate
    ///   condition
    ///   material
    ///   balconyArea
    ///   terraceArea
    ///   loggiaArea
    ///   cellarArea
    ///   ceilingHeight
    ///   poolArea
    ///   acceptanceYear
    ///   constructionYear
    ///   reconstructionYear
    ///   amenities
    ///   roomCount
    ///   floorNumber
    ///   apartmentNumber
    ///   placement
    ///   specialClass
    /// }
    /// 
    /// fragment LandInfo on LandInfo {
    ///   landlType: type
    ///   landArea
    /// }
    /// 
    /// fragment GarageInfo on GarageInfo {
    ///   garageType: type
    ///   usableArea
    /// }
    /// 
    /// fragment HouseInfo on HouseInfo {
    ///   houseType: type
    ///   energyEfficiency
    ///   energyCertificate
    ///   condition
    ///   material
    ///   placement
    ///   roomCount
    ///   ceilingHeight
    ///   amenities
    ///   usableArea
    ///   balconyArea
    ///   terraceArea
    ///   ceilingHeight
    ///   loggiaArea
    ///   reconstructionYear
    ///   constructionYear
    ///   acceptanceYear
    ///   cellarArea
    ///   poolArea
    ///   roomCount
    ///   landArea
    ///   placement
    /// }
    /// 
    /// fragment CommercialInfo on CommercialInfo {
    ///   commercialType: type
    ///   energyEfficiency
    ///   energyCertificate
    ///   condition
    ///   material
    ///   placement
    ///   roomCount
    ///   ceilingHeight
    ///   amenities
    ///   usableArea
    ///   balconyArea
    ///   ceilingHeight
    ///   terraceArea
    ///   loggiaArea
    ///   cellarArea
    ///   poolArea
    ///   constructionYear
    ///   acceptanceYear
    ///   reconstructionYear
    ///   storeArea
    ///   roomCount
    ///   officeArea
    ///   warehouseArea
    ///   productionArea
    ///   placement
    /// }
    /// 
    /// fragment AddressListing on AddressListing {
    ///   lat
    ///   lng
    ///   cityName
    ///   streetName
    ///   ruianCode
    /// }
    /// 
    /// fragment AuctionCard on Auction {
    ///   startingPrice {
    ///     __typename
    ///     ... Price
    ///   }
    ///   serviceType
    ///   estate {
    ///     __typename
    ///     ... Estate
    ///   }
    /// }
    /// 
    /// fragment ProjectCard on Project {
    ///   listingCount
    ///   listings {
    ///     __typename
    ///     ... ProjectListingCard
    ///   }
    /// }
    /// 
    /// fragment ProjectListingCard on ProjectListing {
    ///   satisfiesFilter
    ///   listing {
    ///     __typename
    ///     ... HasListingId
    ///     ... OfferCard
    ///     ... AuctionCard
    ///   }
    /// }
    /// 
    /// fragment HasListingId on Listing {
    ///   listingId
    /// }
    /// 
    /// fragment HasTitle on Listing {
    ///   title
    /// }
    /// 
    /// fragment HasSlideshow on Listing {
    ///   slideshow {
    ///     __typename
    ///     ... Slide
    ///   }
    /// }
    /// 
    /// fragment Slide on Slide {
    ///   ... SlideSingle
    ///   ... SlideDouble
    ///   ... SlideTriple
    /// }
    /// 
    /// fragment SlideSingle on SlideSingle {
    ///   index
    ///   item {
    ///     __typename
    ///     ... Figure
    ///   }
    /// }
    /// 
    /// fragment Figure on Figure {
    ///   ... Matterport
    ///   ... Photo
    ///   ... Video
    /// }
    /// 
    /// fragment Matterport on Matterport {
    ///   url
    /// }
    /// 
    /// fragment Photo on Photo {
    ///   figureId
    ///   url
    ///   originalUrl
    ///   is360
    /// }
    /// 
    /// fragment Video on Video {
    ///   url
    /// }
    /// 
    /// fragment SlideDouble on SlideDouble {
    ///   index
    ///   layout
    ///   itemOne {
    ///     __typename
    ///     ... Figure
    ///   }
    ///   itemTwo {
    ///     __typename
    ///     ... Figure
    ///   }
    /// }
    /// 
    /// fragment SlideTriple on SlideTriple {
    ///   index
    ///   layout
    ///   itemOne {
    ///     __typename
    ///     ... Figure
    ///   }
    ///   itemTwo {
    ///     __typename
    ///     ... Figure
    ///   }
    ///   itemThree {
    ///     __typename
    ///     ... Figure
    ///   }
    /// }
    /// 
    /// fragment HasPhotos on Listing {
    ///   photos {
    ///     __typename
    ///     ... Photo
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetCardQueryDocument : global::StrawberryShake.IDocument
    {
        private GetCardQueryDocument()
        {
        }

        public static GetCardQueryDocument Instance { get; } = new GetCardQueryDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x43, 0x61, 0x72, 0x64, 0x28, 0x24, 0x69, 0x64, 0x3a, 0x20, 0x49, 0x44, 0x21, 0x2c, 0x20, 0x24, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6e, 0x63, 0x79, 0x3a, 0x20, 0x43, 0x75, 0x72, 0x72, 0x65, 0x6e, 0x63, 0x79, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x28, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x3a, 0x20, 0x24, 0x69, 0x64, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x43, 0x61, 0x72, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x43, 0x61, 0x72, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4f, 0x66, 0x66, 0x65, 0x72, 0x43, 0x61, 0x72, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x41, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x43, 0x61, 0x72, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x43, 0x61, 0x72, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x54, 0x69, 0x74, 0x6c, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x73, 0x68, 0x6f, 0x77, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x73, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x4f, 0x66, 0x66, 0x65, 0x72, 0x43, 0x61, 0x72, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x4f, 0x66, 0x66, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x70, 0x72, 0x69, 0x63, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x72, 0x69, 0x63, 0x65, 0x20, 0x7d, 0x20, 0x73, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x54, 0x79, 0x70, 0x65, 0x20, 0x65, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x72, 0x69, 0x63, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x72, 0x69, 0x63, 0x65, 0x20, 0x7b, 0x20, 0x76, 0x61, 0x6c, 0x75, 0x65, 0x28, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6e, 0x63, 0x79, 0x3a, 0x20, 0x24, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6e, 0x63, 0x79, 0x29, 0x20, 0x6f, 0x72, 0x69, 0x67, 0x69, 0x6e, 0x61, 0x6c, 0x43, 0x75, 0x72, 0x72, 0x65, 0x6e, 0x63, 0x79, 0x20, 0x70, 0x65, 0x72, 0x69, 0x6f, 0x64, 0x20, 0x75, 0x6e, 0x69, 0x74, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x7b, 0x20, 0x74, 0x79, 0x70, 0x65, 0x20, 0x65, 0x6c, 0x65, 0x63, 0x74, 0x72, 0x69, 0x63, 0x69, 0x74, 0x79, 0x20, 0x67, 0x61, 0x73, 0x20, 0x77, 0x61, 0x74, 0x65, 0x72, 0x20, 0x68, 0x65, 0x61, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x77, 0x61, 0x73, 0x74, 0x65, 0x20, 0x72, 0x6f, 0x61, 0x64, 0x20, 0x6e, 0x61, 0x74, 0x75, 0x72, 0x65, 0x50, 0x72, 0x6f, 0x74, 0x65, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x63, 0x6f, 0x6e, 0x6e, 0x65, 0x63, 0x74, 0x69, 0x76, 0x69, 0x74, 0x79, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x54, 0x79, 0x70, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x54, 0x79, 0x70, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x7b, 0x20, 0x74, 0x79, 0x70, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x41, 0x70, 0x61, 0x72, 0x74, 0x6d, 0x65, 0x6e, 0x74, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4c, 0x61, 0x6e, 0x64, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x47, 0x61, 0x72, 0x61, 0x67, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x6f, 0x75, 0x73, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x43, 0x6f, 0x6d, 0x6d, 0x65, 0x72, 0x63, 0x69, 0x61, 0x6c, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x41, 0x70, 0x61, 0x72, 0x74, 0x6d, 0x65, 0x6e, 0x74, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x41, 0x70, 0x61, 0x72, 0x74, 0x6d, 0x65, 0x6e, 0x74, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7b, 0x20, 0x61, 0x70, 0x61, 0x72, 0x74, 0x6d, 0x65, 0x6e, 0x74, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x74, 0x79, 0x70, 0x65, 0x20, 0x75, 0x73, 0x61, 0x62, 0x6c, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x6d, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6c, 0x20, 0x65, 0x6e, 0x65, 0x72, 0x67, 0x79, 0x45, 0x66, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6e, 0x63, 0x79, 0x20, 0x65, 0x6e, 0x65, 0x72, 0x67, 0x79, 0x43, 0x65, 0x72, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x65, 0x20, 0x63, 0x6f, 0x6e, 0x64, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x6d, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6c, 0x20, 0x62, 0x61, 0x6c, 0x63, 0x6f, 0x6e, 0x79, 0x41, 0x72, 0x65, 0x61, 0x20, 0x74, 0x65, 0x72, 0x72, 0x61, 0x63, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x6c, 0x6f, 0x67, 0x67, 0x69, 0x61, 0x41, 0x72, 0x65, 0x61, 0x20, 0x63, 0x65, 0x6c, 0x6c, 0x61, 0x72, 0x41, 0x72, 0x65, 0x61, 0x20, 0x63, 0x65, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x48, 0x65, 0x69, 0x67, 0x68, 0x74, 0x20, 0x70, 0x6f, 0x6f, 0x6c, 0x41, 0x72, 0x65, 0x61, 0x20, 0x61, 0x63, 0x63, 0x65, 0x70, 0x74, 0x61, 0x6e, 0x63, 0x65, 0x59, 0x65, 0x61, 0x72, 0x20, 0x63, 0x6f, 0x6e, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x59, 0x65, 0x61, 0x72, 0x20, 0x72, 0x65, 0x63, 0x6f, 0x6e, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x59, 0x65, 0x61, 0x72, 0x20, 0x61, 0x6d, 0x65, 0x6e, 0x69, 0x74, 0x69, 0x65, 0x73, 0x20, 0x72, 0x6f, 0x6f, 0x6d, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x66, 0x6c, 0x6f, 0x6f, 0x72, 0x4e, 0x75, 0x6d, 0x62, 0x65, 0x72, 0x20, 0x61, 0x70, 0x61, 0x72, 0x74, 0x6d, 0x65, 0x6e, 0x74, 0x4e, 0x75, 0x6d, 0x62, 0x65, 0x72, 0x20, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x73, 0x70, 0x65, 0x63, 0x69, 0x61, 0x6c, 0x43, 0x6c, 0x61, 0x73, 0x73, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x4c, 0x61, 0x6e, 0x64, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x61, 0x6e, 0x64, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7b, 0x20, 0x6c, 0x61, 0x6e, 0x64, 0x6c, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x74, 0x79, 0x70, 0x65, 0x20, 0x6c, 0x61, 0x6e, 0x64, 0x41, 0x72, 0x65, 0x61, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x47, 0x61, 0x72, 0x61, 0x67, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x47, 0x61, 0x72, 0x61, 0x67, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7b, 0x20, 0x67, 0x61, 0x72, 0x61, 0x67, 0x65, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x74, 0x79, 0x70, 0x65, 0x20, 0x75, 0x73, 0x61, 0x62, 0x6c, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x6f, 0x75, 0x73, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x48, 0x6f, 0x75, 0x73, 0x65, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7b, 0x20, 0x68, 0x6f, 0x75, 0x73, 0x65, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x74, 0x79, 0x70, 0x65, 0x20, 0x65, 0x6e, 0x65, 0x72, 0x67, 0x79, 0x45, 0x66, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6e, 0x63, 0x79, 0x20, 0x65, 0x6e, 0x65, 0x72, 0x67, 0x79, 0x43, 0x65, 0x72, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x65, 0x20, 0x63, 0x6f, 0x6e, 0x64, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x6d, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6c, 0x20, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x72, 0x6f, 0x6f, 0x6d, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x63, 0x65, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x48, 0x65, 0x69, 0x67, 0x68, 0x74, 0x20, 0x61, 0x6d, 0x65, 0x6e, 0x69, 0x74, 0x69, 0x65, 0x73, 0x20, 0x75, 0x73, 0x61, 0x62, 0x6c, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x62, 0x61, 0x6c, 0x63, 0x6f, 0x6e, 0x79, 0x41, 0x72, 0x65, 0x61, 0x20, 0x74, 0x65, 0x72, 0x72, 0x61, 0x63, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x63, 0x65, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x48, 0x65, 0x69, 0x67, 0x68, 0x74, 0x20, 0x6c, 0x6f, 0x67, 0x67, 0x69, 0x61, 0x41, 0x72, 0x65, 0x61, 0x20, 0x72, 0x65, 0x63, 0x6f, 0x6e, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x59, 0x65, 0x61, 0x72, 0x20, 0x63, 0x6f, 0x6e, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x59, 0x65, 0x61, 0x72, 0x20, 0x61, 0x63, 0x63, 0x65, 0x70, 0x74, 0x61, 0x6e, 0x63, 0x65, 0x59, 0x65, 0x61, 0x72, 0x20, 0x63, 0x65, 0x6c, 0x6c, 0x61, 0x72, 0x41, 0x72, 0x65, 0x61, 0x20, 0x70, 0x6f, 0x6f, 0x6c, 0x41, 0x72, 0x65, 0x61, 0x20, 0x72, 0x6f, 0x6f, 0x6d, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x6c, 0x61, 0x6e, 0x64, 0x41, 0x72, 0x65, 0x61, 0x20, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x43, 0x6f, 0x6d, 0x6d, 0x65, 0x72, 0x63, 0x69, 0x61, 0x6c, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x43, 0x6f, 0x6d, 0x6d, 0x65, 0x72, 0x63, 0x69, 0x61, 0x6c, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6d, 0x6d, 0x65, 0x72, 0x63, 0x69, 0x61, 0x6c, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x74, 0x79, 0x70, 0x65, 0x20, 0x65, 0x6e, 0x65, 0x72, 0x67, 0x79, 0x45, 0x66, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6e, 0x63, 0x79, 0x20, 0x65, 0x6e, 0x65, 0x72, 0x67, 0x79, 0x43, 0x65, 0x72, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x65, 0x20, 0x63, 0x6f, 0x6e, 0x64, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x6d, 0x61, 0x74, 0x65, 0x72, 0x69, 0x61, 0x6c, 0x20, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x72, 0x6f, 0x6f, 0x6d, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x63, 0x65, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x48, 0x65, 0x69, 0x67, 0x68, 0x74, 0x20, 0x61, 0x6d, 0x65, 0x6e, 0x69, 0x74, 0x69, 0x65, 0x73, 0x20, 0x75, 0x73, 0x61, 0x62, 0x6c, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x62, 0x61, 0x6c, 0x63, 0x6f, 0x6e, 0x79, 0x41, 0x72, 0x65, 0x61, 0x20, 0x63, 0x65, 0x69, 0x6c, 0x69, 0x6e, 0x67, 0x48, 0x65, 0x69, 0x67, 0x68, 0x74, 0x20, 0x74, 0x65, 0x72, 0x72, 0x61, 0x63, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x6c, 0x6f, 0x67, 0x67, 0x69, 0x61, 0x41, 0x72, 0x65, 0x61, 0x20, 0x63, 0x65, 0x6c, 0x6c, 0x61, 0x72, 0x41, 0x72, 0x65, 0x61, 0x20, 0x70, 0x6f, 0x6f, 0x6c, 0x41, 0x72, 0x65, 0x61, 0x20, 0x63, 0x6f, 0x6e, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x59, 0x65, 0x61, 0x72, 0x20, 0x61, 0x63, 0x63, 0x65, 0x70, 0x74, 0x61, 0x6e, 0x63, 0x65, 0x59, 0x65, 0x61, 0x72, 0x20, 0x72, 0x65, 0x63, 0x6f, 0x6e, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x59, 0x65, 0x61, 0x72, 0x20, 0x73, 0x74, 0x6f, 0x72, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x72, 0x6f, 0x6f, 0x6d, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x6f, 0x66, 0x66, 0x69, 0x63, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x77, 0x61, 0x72, 0x65, 0x68, 0x6f, 0x75, 0x73, 0x65, 0x41, 0x72, 0x65, 0x61, 0x20, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x41, 0x72, 0x65, 0x61, 0x20, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x6f, 0x6e, 0x20, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x6c, 0x61, 0x74, 0x20, 0x6c, 0x6e, 0x67, 0x20, 0x63, 0x69, 0x74, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x74, 0x72, 0x65, 0x65, 0x74, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x72, 0x75, 0x69, 0x61, 0x6e, 0x43, 0x6f, 0x64, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x41, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x43, 0x61, 0x72, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x41, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x73, 0x74, 0x61, 0x72, 0x74, 0x69, 0x6e, 0x67, 0x50, 0x72, 0x69, 0x63, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x72, 0x69, 0x63, 0x65, 0x20, 0x7d, 0x20, 0x73, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x54, 0x79, 0x70, 0x65, 0x20, 0x65, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x45, 0x73, 0x74, 0x61, 0x74, 0x65, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x43, 0x61, 0x72, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x20, 0x7b, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x43, 0x61, 0x72, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x43, 0x61, 0x72, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x73, 0x61, 0x74, 0x69, 0x73, 0x66, 0x69, 0x65, 0x73, 0x46, 0x69, 0x6c, 0x74, 0x65, 0x72, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4f, 0x66, 0x66, 0x65, 0x72, 0x43, 0x61, 0x72, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x41, 0x75, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x43, 0x61, 0x72, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x54, 0x69, 0x74, 0x6c, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x74, 0x69, 0x74, 0x6c, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x73, 0x68, 0x6f, 0x77, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x73, 0x6c, 0x69, 0x64, 0x65, 0x73, 0x68, 0x6f, 0x77, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x53, 0x69, 0x6e, 0x67, 0x6c, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x44, 0x6f, 0x75, 0x62, 0x6c, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x54, 0x72, 0x69, 0x70, 0x6c, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x53, 0x69, 0x6e, 0x67, 0x6c, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x53, 0x69, 0x6e, 0x67, 0x6c, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x6e, 0x64, 0x65, 0x78, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4d, 0x61, 0x74, 0x74, 0x65, 0x72, 0x70, 0x6f, 0x72, 0x74, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x4d, 0x61, 0x74, 0x74, 0x65, 0x72, 0x70, 0x6f, 0x72, 0x74, 0x20, 0x6f, 0x6e, 0x20, 0x4d, 0x61, 0x74, 0x74, 0x65, 0x72, 0x70, 0x6f, 0x72, 0x74, 0x20, 0x7b, 0x20, 0x75, 0x72, 0x6c, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7b, 0x20, 0x66, 0x69, 0x67, 0x75, 0x72, 0x65, 0x49, 0x64, 0x20, 0x75, 0x72, 0x6c, 0x20, 0x6f, 0x72, 0x69, 0x67, 0x69, 0x6e, 0x61, 0x6c, 0x55, 0x72, 0x6c, 0x20, 0x69, 0x73, 0x33, 0x36, 0x30, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x20, 0x7b, 0x20, 0x75, 0x72, 0x6c, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x44, 0x6f, 0x75, 0x62, 0x6c, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x44, 0x6f, 0x75, 0x62, 0x6c, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x6e, 0x64, 0x65, 0x78, 0x20, 0x6c, 0x61, 0x79, 0x6f, 0x75, 0x74, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x4f, 0x6e, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7d, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x54, 0x77, 0x6f, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x54, 0x72, 0x69, 0x70, 0x6c, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x6c, 0x69, 0x64, 0x65, 0x54, 0x72, 0x69, 0x70, 0x6c, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x6e, 0x64, 0x65, 0x78, 0x20, 0x6c, 0x61, 0x79, 0x6f, 0x75, 0x74, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x4f, 0x6e, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7d, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x54, 0x77, 0x6f, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7d, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x54, 0x68, 0x72, 0x65, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x69, 0x67, 0x75, 0x72, 0x65, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x73, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x20, 0x7b, 0x20, 0x70, 0x68, 0x6f, 0x74, 0x6f, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7d, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("md5Hash", "de114d66b612ddf1a58939c341edf677");
        public override global::System.String ToString()
        {
#if NETSTANDARD2_0
        return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#else
            return global::System.Text.Encoding.UTF8.GetString(Body);
#endif
        }
    }
}
