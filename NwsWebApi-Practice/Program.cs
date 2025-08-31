using NwsWebApi_Practice;
using System.Net.Http.Headers;
using System.Net.Http.Json;

HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/geo+json"));
client.DefaultRequestHeaders.Add("User-Agent", "(example.com, bob@example.com)");

try
{
	var points = await client.GetFromJsonAsync<PointsResponse>("https://api.weather.gov/points/39.7456,-97.0892");
	var forecast = await client.GetFromJsonAsync<ForecastResponse>(points?.Properties.forecast);
	if (forecast?.properties?.periods != null)
	{
		foreach (var period in forecast.properties.periods)
		{
			Console.WriteLine($"{period.name}: {period.detailedForecast}");
		}
	}
}
catch (Exception ex)
{
	Console.WriteLine($"An error has occurred: {ex.Message}");
}




client.Dispose();