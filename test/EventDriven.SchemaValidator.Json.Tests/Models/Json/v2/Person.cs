using System.ComponentModel.DataAnnotations;

namespace EventDriven.SchemaValidator.Json.Tests.Models.Json.v2;

public class Person
{
    [Required]
    public string Name { get; set; } = null!;

    public string? Planet { get; set; }
}