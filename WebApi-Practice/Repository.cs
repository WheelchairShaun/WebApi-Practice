using System.Text.Json.Serialization;

namespace WebApi_Practice
{
	public record class Repository([property: JsonPropertyName("name")] string Name);
}
