using System.Text.Json.Serialization;

namespace Evanston;

public class DirectoryDto
{
    [JsonPropertyName("businesses")]
    public BusinessDto[] Businesses { get; set; } = [];
}