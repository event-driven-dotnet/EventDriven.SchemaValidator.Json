using System.Collections.Generic;
using System.Linq;
using EventDriven.SchemaRegistry.Abstractions;
using NJsonSchema;

namespace EventDriven.SchemaValidator.Json;

/// <inheritdoc />
public class JsonSchemaValidator : ISchemaValidator
{
    /// <inheritdoc />
    public bool ValidateMessage(string message, string schema, out IList<string> errorMessages)
    {
        var jsonSchema = JsonSchema.FromJsonAsync(schema).Result;
        var errors = jsonSchema.Validate(message);
        errorMessages = errors.Select(error => error.Path + ": " + error.Kind).ToList();
        return !errors.Any();
    }
}