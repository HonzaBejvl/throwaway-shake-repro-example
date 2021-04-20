﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the ListingAddVideo GraphQL operation
    /// <code>
    /// mutation ListingAddVideo($listingId: ID!, $videoUrl: Url!) {
    ///   listingAddVideo(listingId: $listingId, videoUrl: $videoUrl) {
    ///     __typename
    ///     ... ListingAddVideoPayload
    ///   }
    /// }
    /// 
    /// fragment ListingAddVideoPayload on ListingAddVideoPayload {
    ///   result {
    ///     __typename
    ///     ... Video
    ///   }
    /// }
    /// 
    /// fragment Video on Video {
    ///   url
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class ListingAddVideoMutationDocument : global::StrawberryShake.IDocument
    {
        private ListingAddVideoMutationDocument()
        {
        }

        public static ListingAddVideoMutationDocument Instance { get; } = new ListingAddVideoMutationDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Mutation;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x6d, 0x75, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x41, 0x64, 0x64, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x28, 0x24, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x3a, 0x20, 0x49, 0x44, 0x21, 0x2c, 0x20, 0x24, 0x76, 0x69, 0x64, 0x65, 0x6f, 0x55, 0x72, 0x6c, 0x3a, 0x20, 0x55, 0x72, 0x6c, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x41, 0x64, 0x64, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x28, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x3a, 0x20, 0x24, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x2c, 0x20, 0x76, 0x69, 0x64, 0x65, 0x6f, 0x55, 0x72, 0x6c, 0x3a, 0x20, 0x24, 0x76, 0x69, 0x64, 0x65, 0x6f, 0x55, 0x72, 0x6c, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x41, 0x64, 0x64, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x50, 0x61, 0x79, 0x6c, 0x6f, 0x61, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x41, 0x64, 0x64, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x50, 0x61, 0x79, 0x6c, 0x6f, 0x61, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x41, 0x64, 0x64, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x50, 0x61, 0x79, 0x6c, 0x6f, 0x61, 0x64, 0x20, 0x7b, 0x20, 0x72, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x56, 0x69, 0x64, 0x65, 0x6f, 0x20, 0x7b, 0x20, 0x75, 0x72, 0x6c, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("md5Hash", "25ff0b41d2875094bc6e077713e7ec45");
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
