﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class LocalizationInput : global::Logic.Graphql.Generated.State.ILocalizationInputInfo
    {
        private global::Logic.Graphql.Generated.Language _value_language;
        private global::System.Boolean _set_language;
        private global::System.String _value_title = default !;
        private global::System.Boolean _set_title;
        private global::System.String _value_description = default !;
        private global::System.Boolean _set_description;
        public global::Logic.Graphql.Generated.Language Language
        {
            get => _value_language;
            set
            {
                _set_language = true;
                _value_language = value;
            }
        }

        global::System.Boolean global::Logic.Graphql.Generated.State.ILocalizationInputInfo.IsLanguageSet => _set_language;
        public global::System.String Title
        {
            get => _value_title;
            set
            {
                _set_title = true;
                _value_title = value;
            }
        }

        global::System.Boolean global::Logic.Graphql.Generated.State.ILocalizationInputInfo.IsTitleSet => _set_title;
        public global::System.String Description
        {
            get => _value_description;
            set
            {
                _set_description = true;
                _value_description = value;
            }
        }

        global::System.Boolean global::Logic.Graphql.Generated.State.ILocalizationInputInfo.IsDescriptionSet => _set_description;
    }
}
