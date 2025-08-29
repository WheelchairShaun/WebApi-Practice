using System.Text.Json;

namespace WebApi_Practice
{
	public static class GitHubProcessor
	{
		public static async Task<List<Repository>> GetRepositoriesAsync(HttpClient client)
		{
			await using Stream stream = await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
			var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);

			return repositories ?? new();
		}
	}
}
