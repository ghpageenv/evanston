using System.Text.Json.Serialization;

namespace Evanston;

public class BusinessDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("chiefExecutive")]
    public string? ChiefExecutive { get; set; }

    [JsonPropertyName("targetClient")]
    public string? TargetClient { get; set; }

    [JsonPropertyName("anchor")]
    public string? Anchor { get; set; }

    [JsonPropertyName("categories")]
    public BusinessCategory[] Categories { get; set; } = [];
}