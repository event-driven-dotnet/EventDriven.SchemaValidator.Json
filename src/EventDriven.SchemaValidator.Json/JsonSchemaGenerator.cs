using System;
using EventDriven.SchemaRegistry.Abstractions;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;

namespace EventDriven.SchemaValidator.Json
{
    /// <inheritdoc />
    public class JsonSchemaGenerator : ISchemaGenerator
    {
        private readonly JSchemaGenerator _jsonSchemaGenerator;

        /// <summary>
        /// JsonSchemaGenerator constructor.`
        /// </summary>
        public JsonSchemaGenerator()
        {
            _jsonSchemaGenerator = new JSchemaGenerator
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                SchemaIdGenerationHandling = SchemaIdGenerationHandling.TypeName
            };
        }

        /// <inheritdoc />
        public string GenerateSchema(Type messageType) => 
            _jsonSchemaGenerator.Generate(messageType).ToString();
    }
}