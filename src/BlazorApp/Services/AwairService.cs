using BlazorApp.Models;
using Microsoft.Extensions.Options;

namespace BlazorApp.Services;

public class AwairService
{
    private readonly HttpClient _httpClient;
    private readonly AwairOptions _awairOptions;
    
    public AwairService(HttpClient httpClient, IOptions<AwairOptions> awairOptions)
    {
        _httpClient = httpClient;
        _awairOptions = awairOptions.Value;
    }

    public async Task<List<AwairDeviceData>> GetAwairDeviceDataAsync()
    {
        List<AwairDeviceData> data = new();
        foreach (var device in _awairOptions.Devices)
        {
            data.Add(new AwairDeviceData()
            {
                DisplayName = device.DisplayName,
                Data = await _httpClient.GetFromJsonAsync<AwairData>(new Uri($"http://{device.Address}/air-data/latest"))
            });
        }

        return data;
    }
}