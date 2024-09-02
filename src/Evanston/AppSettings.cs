using System.Text.Json.Serialization;

namespace Evanston;

public class AppSettings
{
    [JsonPropertyName("businesses")]
    public BusinessDto[] Businesses { get; set; } = [];
}