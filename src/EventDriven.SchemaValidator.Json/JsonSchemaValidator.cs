using System.Collections.Generic;
using EventDriven.SchemaRegistry.Abstractions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace EventDriven.SchemaValidator.Json
{
    /// <inheritdoc />
    public class JsonSchemaValidator : ISchemaValidator
    {
        /// <inheritdoc />
        public void ValidateSchema(string message, string schema, out IList<string> errorMessages)
        {
            var jObject = JObject.Parse(message);
            var jSchema = JSchema.Parse(schema);
            jObject.IsValid(jSchema, out errorMessages);
        }
    }
}