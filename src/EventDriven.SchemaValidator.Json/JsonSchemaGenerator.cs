using System;
using EventDriven.SchemaRegistry.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NJsonSchema;
using NJsonSchema.Generation;

namespace EventDriven.SchemaValidator.Json
{
    /// <inheritdoc />
    public class JsonSchemaGenerator : ISchemaGenerator
    {
        /// <inheritdoc />
        public string GenerateSchema(Type messageType) =>
            JsonSchema.FromType(messageType, new JsonSchemaGeneratorSettings
            {
                SerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                },
                AlwaysAllowAdditionalObjectProperties = true
            })
            .ToJson();
    }
}