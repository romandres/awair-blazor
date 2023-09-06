using BlazorApp.Models;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages;

public partial class Index
{
    [Inject]
    public required IMediator Mediator { get; init; }

    public IQueryable<AwairDeviceData> AirData
    {
        get => airData.AsQueryable();
    }

    private List<AwairDeviceData> airData = new();
    
    public DateTimeOffset LastRefresh { get; set; } = DateTimeOffset.UtcNow;
    
    public bool IsNewAirData { get; set; }
    
    public bool IsLoading { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await GetData();
        }
    }

    protected async Task RefreshAsync()
    {
        await GetData();
    }

    private async Task GetData()
    {
        IsLoading = true;
        StateHasChanged();

        LastRefresh = DateTimeOffset.UtcNow;
        var newAirData = await Mediator.Send(new GetAwairDeviceDataQuery());
        IsNewAirData = airData.Count == 0 || airData.Last().Data.Timestamp < newAirData.Last().Data.Timestamp;
        if (IsNewAirData)
        {
            airData.AddRange(newAirData);
        }

        IsLoading = false;
        
        StateHasChanged();
    }
}