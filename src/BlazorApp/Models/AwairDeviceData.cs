namespace BlazorApp.Models;

public record class AwairDeviceData
{
    public required string DisplayName { get; init; }
    
    public required AwairData Data { get; init; }
}