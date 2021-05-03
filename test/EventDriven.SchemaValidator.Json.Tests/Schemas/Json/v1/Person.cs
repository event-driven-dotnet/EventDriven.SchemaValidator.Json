namespace EventDriven.SchemaValidator.Json.Tests.Schemas.Json.v1
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
    ""age"": {
      ""type"": [
        ""integer"",
        ""null""
      ]
    }
  },
  ""required"": [
    ""name"",
    ""age""
  ]
}";
    }
}