using System;
using System.Text.Json.Serialization;

public class Product
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName ("key")]
	public string Key { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("price_min")]
	public string Price_min { get; set; }

	[JsonPropertyName("price_max")]
    public string Price_max { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }

}
