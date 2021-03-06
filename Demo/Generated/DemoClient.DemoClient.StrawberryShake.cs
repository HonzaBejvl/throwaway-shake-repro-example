// <auto-generated/>
#nullable enable

namespace Demo.Graphql
{
    /// <summary>
    /// Represents the DemoClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class DemoClient : global::Demo.Graphql.IDemoClient
    {
        private readonly global::Demo.Graphql.IGetAllQuery _getAll;
        public DemoClient(global::Demo.Graphql.IGetAllQuery getAll)
        {
            _getAll = getAll ?? throw new global::System.ArgumentNullException(nameof(getAll));
        }

        public static global::System.String ClientName => "DemoClient";
        public global::Demo.Graphql.IGetAllQuery GetAll => _getAll;
    }
}
