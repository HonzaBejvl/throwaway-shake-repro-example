﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetListingCards_Listings_Items_Slideshow_ItemOne_Photo_1 : global::System.IEquatable<GetListingCards_Listings_Items_Slideshow_ItemOne_Photo_1>, IGetListingCards_Listings_Items_Slideshow_ItemOne_Photo_1
    {
        public GetListingCards_Listings_Items_Slideshow_ItemOne_Photo_1(global::System.String figureId, global::System.Uri url, global::System.Uri originalUrl, global::System.Boolean is360)
        {
            FigureId = figureId;
            Url = url;
            OriginalUrl = originalUrl;
            Is360 = is360;
        }

        public global::System.String FigureId { get; }

        public global::System.Uri Url { get; }

        public global::System.Uri OriginalUrl { get; }

        public global::System.Boolean Is360 { get; }

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

            return Equals((GetListingCards_Listings_Items_Slideshow_ItemOne_Photo_1)obj);
        }

        public global::System.Boolean Equals(GetListingCards_Listings_Items_Slideshow_ItemOne_Photo_1? other)
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

            return (FigureId.Equals(other.FigureId)) && Url.Equals(other.Url) && OriginalUrl.Equals(other.OriginalUrl) && Is360 == other.Is360;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * FigureId.GetHashCode();
                hash ^= 397 * Url.GetHashCode();
                hash ^= 397 * OriginalUrl.GetHashCode();
                hash ^= 397 * Is360.GetHashCode();
                return hash;
            }
        }
    }
}
