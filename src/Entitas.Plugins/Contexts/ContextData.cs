﻿using Jenny;

namespace Entitas.Plugins
{
    public class ContextData : CodeGeneratorData
    {
        public const string NameKey = "Context.Name";
        public const string TypeKey = "Context.Type";
        public const string EntityTypeKey = "Entity.Type";

        public string Name
        {
            get => (string)this[NameKey];
            set => this[NameKey] = value;
        }

        public string Type
        {
            get => (string)this[TypeKey];
            set => this[TypeKey] = value;
        }

        public string EntityType
        {
            get => (string)this[EntityTypeKey];
            set => this[EntityTypeKey] = value;
        }
    }
}
