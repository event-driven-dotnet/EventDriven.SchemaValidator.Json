using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Xunit;
using Model_v1 = EventDriven.SchemaValidator.Json.Tests.Models.Json.v1;
using Model_v2 = EventDriven.SchemaValidator.Json.Tests.Models.Json.v2;
using Schema_v1 = EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v1;
using Schema_v2 = EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v2;

namespace EventDriven.SchemaValidator.Json.Tests;

public class SchemaValidatorTests
{
    [Fact]
    public void Given_v1Model_And_v1Schema_Then_SchemaValidatorShouldValidateJson()
    {
        // Arrange
        var schemaValidator = new JsonSchemaValidator();
        var person = new Model_v1.Person { Name = "Yoda", Age = 100 };
        var settings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };
        var json = JsonConvert.SerializeObject(person, settings);

        // Act
        var result = schemaValidator.ValidateMessage(json, 
            Schema_v1.Person.Expected, out var errorMessages);

        // Assert
        Assert.True(result);
        Assert.Empty(errorMessages);
    }

    [Fact]
    public void Given_v2Model_And_v1Schema_Then_SchemaValidatorShouldValidateJson()
    {
        // Arrange
        var schemaValidator = new JsonSchemaValidator();
        var person = new Model_v2.Person { Name = "Yoda", Planet = "Dagobah" };
        var settings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };
        var json = JsonConvert.SerializeObject(person, settings);

        // Act
        var result = schemaValidator.ValidateMessage(json, 
            Schema_v1.Person.Expected, out var errorMessages);

        // Assert
        Assert.True(result);
        Assert.Empty(errorMessages);
    }
    
    [Fact]
    public void Given_v1Model_With_MissingRequiredField_And_v1Schema_Then_SchemaValidatorShouldNotValidateJson()
    {
        // Arrange
        var schemaValidator = new JsonSchemaValidator();
        var person = new Model_v1.Person();
        var settings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };
        var json = JsonConvert.SerializeObject(person, settings);

        // Act
        var result = schemaValidator.ValidateMessage(json, 
            Schema_v1.Person.Expected, out var errorMessages);

        // Assert
        Assert.False(result);
        Assert.Equal("#/name: StringExpected", errorMessages.Single());
    }
    
    [Fact]
    public void Given_v2Model_With_MissingRequiredField_And_v1Schema_Then_SchemaValidatorShouldNotValidateJson()
    {
        // Arrange
        var schemaValidator = new JsonSchemaValidator();
        var person = new Model_v2.Person();
        var settings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };
        var json = JsonConvert.SerializeObject(person, settings);

        // Act
        var result = schemaValidator.ValidateMessage(json, 
            Schema_v1.Person.Expected, out var errorMessages);

        // Assert
        Assert.False(result);
        Assert.Equal("#/name: StringExpected", errorMessages.Single());
    }
}