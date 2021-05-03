namespace EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v2
{
    public static class Person
    {
        public const string Expected = @"{
  ""$id"": ""Person"",
  ""type"": ""object"",
  ""properties"": {
    ""name"": {
      ""type"": [
        ""string"",
        ""null""
      ]
    },
    ""planet"": {
      ""type"": [
        ""string"",
        ""null""
      ]
    }
  },
  ""required"": [
    ""name"",
    ""planet""
  ]
}";
    }
}