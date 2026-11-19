using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

public class OnlinerResponse
{
	[JsonPropertyName("products")]
	public List<Product> Products { get; set; }

	
}
