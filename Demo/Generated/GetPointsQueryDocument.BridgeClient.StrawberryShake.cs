﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetPoints GraphQL operation
    /// <code>
    /// query GetPoints($filter: ListingFilter!) {
    ///   points(filter: $filter) {
    ///     __typename
    ///     ... Point
    ///   }
    /// }
    /// 
    /// fragment Point on Point {
    ///   ... PointProject
    ///   ... PointSimple
    ///   gps {
    ///     __typename
    ///     ... Gps
    ///   }
    /// }
    /// 
    /// fragment PointProject on PointProject {
    ///   count
    ///   listingId
    /// }
    /// 
    /// fragment PointSimple on PointSimple {
    ///   listingId
    /// }
    /// 
    /// fragment Gps on Gps {
    ///   lat
    ///   lng
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetPointsQueryDocument : global::StrawberryShake.IDocument
    {
        private GetPointsQueryDocument()
        {
        }

        public static GetPointsQueryDocument Instance { get; } = new GetPointsQueryDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x73, 0x28, 0x24, 0x66, 0x69, 0x6c, 0x74, 0x65, 0x72, 0x3a, 0x20, 0x4c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x46, 0x69, 0x6c, 0x74, 0x65, 0x72, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x70, 0x6f, 0x69, 0x6e, 0x74, 0x73, 0x28, 0x66, 0x69, 0x6c, 0x74, 0x65, 0x72, 0x3a, 0x20, 0x24, 0x66, 0x69, 0x6c, 0x74, 0x65, 0x72, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x53, 0x69, 0x6d, 0x70, 0x6c, 0x65, 0x20, 0x67, 0x70, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x47, 0x70, 0x73, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x53, 0x69, 0x6d, 0x70, 0x6c, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x6f, 0x69, 0x6e, 0x74, 0x53, 0x69, 0x6d, 0x70, 0x6c, 0x65, 0x20, 0x7b, 0x20, 0x6c, 0x69, 0x73, 0x74, 0x69, 0x6e, 0x67, 0x49, 0x64, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x47, 0x70, 0x73, 0x20, 0x6f, 0x6e, 0x20, 0x47, 0x70, 0x73, 0x20, 0x7b, 0x20, 0x6c, 0x61, 0x74, 0x20, 0x6c, 0x6e, 0x67, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("md5Hash", "34d6abfd77ff3c26ecc3e375b2a09292");
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
