using System.Text.Json.Serialization;

namespace BlazorApp.Models;

public record class AwairData
{
    /// <summary>
    /// The UTC ISO8610 formatted time that the sample was taken based on the device’s internal clock.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; init; }
    
    /// <summary>
    /// Awair Score (0-100).
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }
    
    /// <summary>
    /// The temperature at which water will condense and form into dew (ºC by default).
    /// </summary>
    [JsonPropertyName("dew_point")]
    public required double DewPoint { get; init; }
    
    /// <summary>
    /// Dry bulb temperature (ºC by default).
    /// </summary>
    [JsonPropertyName("temp")]
    public required double Temperature { get; init; }

    /// <summary>
    /// Relative Humidity (%).
    /// </summary>
    [JsonPropertyName("humid")]
    public required double Humidity { get; init; }
    
    /// <summary>
    /// Absolute Humidity (g/m³).
    /// </summary>
    [JsonPropertyName("abs_humid")]
    public required double AbsoluteHumidity { get; init; }
    
    /// <summary>
    /// Carbon Dioxide (ppm).
    /// </summary>
    [JsonPropertyName("co2")]
    public required int CarbonDioxide { get; init; }
    
    /// <summary>
    /// Estimated Carbon Dioxide (ppm - calculated by the TVOC sensor).
    /// </summary>
    [JsonPropertyName("co2_est")]
    public required int EstimatedCarbonDioxide { get; init; }
    
    /// <summary>
    /// A unitless value that represents the baseline from which the TVOC sensor partially derives its estimated (e)CO₂output.
    /// </summary>
    [JsonPropertyName("co2_est_baseline")]
    public required int EstimatedCarbonDioxideBaseline { get; init; }
    
    /// <summary>
    /// Total Volatile Organic Compounds (ppb).
    /// </summary>
    [JsonPropertyName("voc")]
    public required int VolatileOrganicCompounds { get; init; }
    
    /// <summary>
    /// A unitless value that represents the baseline from which the TVOC sensor partially derives its TVOC output.
    /// </summary>
    [JsonPropertyName("voc_baseline")]
    public required int VolatileOrganicCompoundsBaseline { get; init; }
    
    /// <summary>
    /// A unitless value that represents the Hydrogen gas signal from which the TVOC sensor partially derives its TVOC output.
    /// </summary>
    [JsonPropertyName("voc_h2_raw")]
    public required int VolatileOrganicCompoundsHydrogenRaw { get; init; }
    
    /// <summary>
    /// A unitless value that represents the Ethanol gas signal from which the TVOC sensor partially derives its TVOC output.
    /// </summary>
    [JsonPropertyName("voc_ethanol_raw")]
    public required int VolatileOrganicCompoundsEthanolRaw { get; init; }
    
    /// <summary>
    /// Particulate matter less than 2.5 microns in diameter (µg/m³).
    /// </summary>
    [JsonPropertyName("pm25")]
    public required int ParticulateMatter25 { get; init; }
    
    /// <summary>
    /// Estimated particulate matter less than 10 microns in diameter (µg/m³ - calculated by the PM2.5 sensor).
    /// </summary>
    [JsonPropertyName("pm10_est")]
    public required int EstimatedParticulateMatter10 { get; init; }
}