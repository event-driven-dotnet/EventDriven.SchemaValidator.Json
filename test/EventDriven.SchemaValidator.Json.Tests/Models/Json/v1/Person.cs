using System.ComponentModel.DataAnnotations;

namespace EventDriven.SchemaValidator.Json.Tests.Models.Json.v1;

public class Person
{
    [Required]
    public string Name { get; set; } = null!;

    [Range(1, 100)]
    public int? Age { get; set; }
}