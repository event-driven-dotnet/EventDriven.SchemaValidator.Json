using Xunit;
using Model_v1 = EventDriven.SchemaValidator.Json.Tests.Models.Json.v1;
using Model_v2 = EventDriven.SchemaValidator.Json.Tests.Models.Json.v2;
using Schema_v1 = EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v1;
using Schema_v2 = EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v2;

namespace EventDriven.SchemaValidator.Json.Tests;

public class SchemaGeneratorTests
{
    [Fact]
    public void Given_Model_v1_Then_SchemaGeneratorShouldGenerateSchema_v1()
    {
        // Arrange
        var schemaGenerator = new JsonSchemaGenerator();

        // Act
        var schema = schemaGenerator.GenerateSchema(typeof(Model_v1.Person));

        // Assert
        Assert.Equal(Schema_v1.Person.Expected, schema);
    }
    
    [Fact]
    public void Given_Model_v2_Then_SchemaGeneratorShouldGenerateSchema_v2()
    {
        // Arrange
        var schemaGenerator = new JsonSchemaGenerator();

        // Act
        var schema = schemaGenerator.GenerateSchema(typeof(Model_v2.Person));

        // Assert
        Assert.Equal(Schema_v2.Person.Expected, schema);
    }
}