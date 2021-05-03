using EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v1;
using Xunit;
using EventDrivenSchemaGenerator = EventDriven.SchemaValidator.Json.JsonSchemaGenerator;

namespace EventDriven.SchemaValidator.Json.Tests
{
    public class SchemaGeneratorTests
    {
        [Fact]
        public void Json_SchemaGenerator_Should_Generate_Schema()
        {
            // Arrange
            var schemaGenerator = new EventDrivenSchemaGenerator();

            // Act
            var schema = schemaGenerator.GenerateSchema(typeof(SchemaValidator.Json.Tests.Models.Json.v1.Person));

            // Assert
            Assert.Equal(Person.Expected, schema);
        }
    }
}