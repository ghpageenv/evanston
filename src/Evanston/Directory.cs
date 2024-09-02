using System.Text.Json.Serialization;

namespace Evanston;

public class Directory
{
    [JsonPropertyName("businesses")]
    public BusinessDto[] Businesses { get; set; } = [];
}