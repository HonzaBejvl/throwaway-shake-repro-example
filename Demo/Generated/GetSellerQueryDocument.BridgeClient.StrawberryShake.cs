﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetSeller GraphQL operation
    /// <code>
    /// query GetSeller($sellerId: ID!) {
    ///   seller(sellerId: $sellerId) {
    ///     __typename
    ///     ... Seller
    ///   }
    /// }
    /// 
    /// fragment Seller on Seller {
    ///   ... Broker
    ///   ... Individual
    ///   ... Office
    ///   ... Company
    /// }
    /// 
    /// fragment Broker on Broker {
    ///   ... HasBrokerInformation
    ///   company {
    ///     __typename
    ///     ... Company
    ///   }
    /// }
    /// 
    /// fragment HasBrokerInformation on Broker {
    ///   sellerId
    ///   name
    ///   photo {
    ///     __typename
    ///     ... Photo
    ///   }
    /// }
    /// 
    /// fragment Photo on Photo {
    ///   figureId
    ///   url
    ///   originalUrl
    ///   is360
    /// }
    /// 
    /// fragment Company on Company {
    ///   ... HasCompanyInformation
    /// }
    /// 
    /// fragment HasCompanyInformation on Company {
    ///   name
    ///   photo {
    ///     __typename
    ///     ... Photo
    ///   }
    ///   headquarters {
    ///     __typename
    ///     ... Address
    ///   }
    /// }
    /// 
    /// fragment Address on Address {
    ///   lat
    ///   lng
    ///   cityName
    ///   streetName
    ///   ruianCode
    /// }
    /// 
    /// fragment Individual on Individual {
    ///   sellerId
    /// }
    /// 
    /// fragment Office on Office {
    ///   sellerId
    ///   name
    ///   photo {
    ///     __typename
    ///     ... Photo
    ///   }
    ///   company {
    ///     __typename
    ///     ... Company
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetSellerQueryDocument : global::StrawberryShake.IDocument
    {
        private GetSellerQueryDocument()
        {
        }

        public static GetSellerQueryDocument Instance { get; } = new GetSellerQueryDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x53, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x28, 0x24, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x49, 0x64, 0x3a, 0x20, 0x49, 0x44, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x28, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x49, 0x64, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x49, 0x64, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x42, 0x72, 0x6f, 0x6b, 0x65, 0x72, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x49, 0x6e, 0x64, 0x69, 0x76, 0x69, 0x64, 0x75, 0x61, 0x6c, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x4f, 0x66, 0x66, 0x69, 0x63, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x42, 0x72, 0x6f, 0x6b, 0x65, 0x72, 0x20, 0x6f, 0x6e, 0x20, 0x42, 0x72, 0x6f, 0x6b, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x42, 0x72, 0x6f, 0x6b, 0x65, 0x72, 0x49, 0x6e, 0x66, 0x6f, 0x72, 0x6d, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x63, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x42, 0x72, 0x6f, 0x6b, 0x65, 0x72, 0x49, 0x6e, 0x66, 0x6f, 0x72, 0x6d, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x6f, 0x6e, 0x20, 0x42, 0x72, 0x6f, 0x6b, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x49, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x70, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7b, 0x20, 0x66, 0x69, 0x67, 0x75, 0x72, 0x65, 0x49, 0x64, 0x20, 0x75, 0x72, 0x6c, 0x20, 0x6f, 0x72, 0x69, 0x67, 0x69, 0x6e, 0x61, 0x6c, 0x55, 0x72, 0x6c, 0x20, 0x69, 0x73, 0x33, 0x36, 0x30, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x6f, 0x6e, 0x20, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x48, 0x61, 0x73, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x49, 0x6e, 0x66, 0x6f, 0x72, 0x6d, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x48, 0x61, 0x73, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x49, 0x6e, 0x66, 0x6f, 0x72, 0x6d, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x6f, 0x6e, 0x20, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x70, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7d, 0x20, 0x68, 0x65, 0x61, 0x64, 0x71, 0x75, 0x61, 0x72, 0x74, 0x65, 0x72, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x6f, 0x6e, 0x20, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x7b, 0x20, 0x6c, 0x61, 0x74, 0x20, 0x6c, 0x6e, 0x67, 0x20, 0x63, 0x69, 0x74, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x74, 0x72, 0x65, 0x65, 0x74, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x72, 0x75, 0x69, 0x61, 0x6e, 0x43, 0x6f, 0x64, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x49, 0x6e, 0x64, 0x69, 0x76, 0x69, 0x64, 0x75, 0x61, 0x6c, 0x20, 0x6f, 0x6e, 0x20, 0x49, 0x6e, 0x64, 0x69, 0x76, 0x69, 0x64, 0x75, 0x61, 0x6c, 0x20, 0x7b, 0x20, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x49, 0x64, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x4f, 0x66, 0x66, 0x69, 0x63, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x4f, 0x66, 0x66, 0x69, 0x63, 0x65, 0x20, 0x7b, 0x20, 0x73, 0x65, 0x6c, 0x6c, 0x65, 0x72, 0x49, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x70, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x50, 0x68, 0x6f, 0x74, 0x6f, 0x20, 0x7d, 0x20, 0x63, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x43, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x20, 0x7d, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("md5Hash", "1fb051b738f52b694371ff1a1b872a2b");
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