using System.Net.Http.Headers;
using WebApi_Practice;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

var repositories = await GitHubProcessor.GetRepositoriesAsync(client);

foreach (var repo in repositories)
{
	Console.WriteLine($"Name: {repo.Name}");
	Console.WriteLine($"Homepage: {repo.Homepage}");
	Console.WriteLine($"GitHub: {repo.GitHubHomeUrl}");
	Console.WriteLine($"Description: {repo.Description}");
	Console.WriteLine($"Watchers: {repo.Watchers:#,0}");
	Console.WriteLine($"Last Push: {repo.LastPush}");
	Console.WriteLine();
}

