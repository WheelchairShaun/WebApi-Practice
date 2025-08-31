using System.Text.Json.Serialization;

namespace NwsWebApi_Practice
{
	public class PointsResponse
	{
		[property: JsonPropertyName("@context")]
		public object[] Context { get; set; }

		[property: JsonPropertyName("id")]
		public Uri Id { get; set; }

		[property: JsonPropertyName("type")]
		public string Type { get; set; }

		[property: JsonPropertyName("geometry")]
		public Geometry Geometry { get; set; }

		[property: JsonPropertyName("properties")]
		public ContextProperties Properties { get; set; }
	}

	public class Geometry
	{
		public string type { get; set; }
		public float[] coordinates { get; set; }
	}

	public class ContextProperties
	{
		public Uri id { get; set; }
		public string type { get; set; }
		public string cwa { get; set; }
		public Uri forecastOffice { get; set; }
		public string gridId { get; set; }
		public int gridX { get; set; }
		public int gridY { get; set; }
		public Uri forecast { get; set; }
		public Uri forecastHourly { get; set; }
		public Uri forecastGridData { get; set; }
		public Uri observationStations { get; set; }
		public Relativelocation relativeLocation { get; set; }
		public Uri forecastZone { get; set; }
		public Uri county { get; set; }
		public Uri fireWeatherZone { get; set; }
		public string timeZone { get; set; }
		public string radarStation { get; set; }
	}

	public class Relativelocation
	{
		public string type { get; set; }
		public Geometry geometry { get; set; }

		[property: JsonPropertyName("properties")]
		public RelativeLocationProperties Properties { get; set; }
	}

	public class RelativeLocationProperties
	{
		public string city { get; set; }
		public string state { get; set; }
		public Distance distance { get; set; }
		public Bearing bearing { get; set; }
	}

	public class Distance
	{
		public string unitCode { get; set; }
		public float value { get; set; }
	}

	public class Bearing
	{
		public string unitCode { get; set; }
		public int value { get; set; }
	}

}
