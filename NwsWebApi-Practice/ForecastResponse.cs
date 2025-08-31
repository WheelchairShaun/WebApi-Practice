using System.Text.Json.Serialization;

namespace NwsWebApi_Practice
{
	internal class ForecastResponse
	{
		[property: JsonPropertyName("@context")]
		public object[] Context { get; set; }
		public string type { get; set; }
		public ForecastGeometry geometry { get; set; }
		public Properties properties { get; set; }
	}

	public class ForecastGeometry
	{
		public string type { get; set; }
		public float[][][] coordinates { get; set; }
	}

	public class Properties
	{
		public string units { get; set; }
		public string forecastGenerator { get; set; }
		public DateTime generatedAt { get; set; }
		public DateTime updateTime { get; set; }
		public string validTimes { get; set; }
		public Elevation elevation { get; set; }
		public Period[] periods { get; set; }
	}

	public class Elevation
	{
		public string unitCode { get; set; }
		public float value { get; set; }
	}

	public class Period
	{
		public int number { get; set; }
		public string name { get; set; }
		public DateTime startTime { get; set; }
		public DateTime endTime { get; set; }
		public bool isDaytime { get; set; }
		public int temperature { get; set; }
		public string temperatureUnit { get; set; }
		public string temperatureTrend { get; set; }
		public Probabilityofprecipitation probabilityOfPrecipitation { get; set; }
		public string windSpeed { get; set; }
		public string windDirection { get; set; }
		public string icon { get; set; }
		public string shortForecast { get; set; }
		public string detailedForecast { get; set; }
	}

	public class Probabilityofprecipitation
	{
		public string unitCode { get; set; }
		public int value { get; set; }
	}

}
