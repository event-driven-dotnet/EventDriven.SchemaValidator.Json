namespace EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v1;

public static class Person
{
  public const string Expected = @"{
  ""$schema"": ""http://json-schema.org/draft-04/schema#"",
  ""title"": ""Person"",
  ""type"": ""object"",
  ""required"": [
    ""name""
  ],
  ""properties"": {
    ""name"": {
      ""type"": ""string"",
      ""minLength"": 1
    },
    ""age"": {
      ""type"": [
        ""integer"",
        ""null""
      ],
      ""format"": ""int32"",
      ""maximum"": 100.0,
      ""minimum"": 1.0
    }
  }
}";
}