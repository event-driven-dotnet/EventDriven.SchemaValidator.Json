namespace EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v2;

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
    ""planet"": {
      ""type"": [
        ""null"",
        ""string""
      ]
    }
  }
}";
}