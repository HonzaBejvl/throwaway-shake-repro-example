﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class RentInput : global::Logic.Graphql.Generated.State.IRentInputInfo
    {
        private global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Restriction> _value_restriction;
        private global::System.Boolean _set_restriction;
        public global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.Restriction> Restriction
        {
            get => _value_restriction;
            set
            {
                _set_restriction = true;
                _value_restriction = value;
            }
        }

        global::System.Boolean global::Logic.Graphql.Generated.State.IRentInputInfo.IsRestrictionSet => _set_restriction;
    }
}
