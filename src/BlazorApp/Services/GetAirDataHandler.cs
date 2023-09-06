using BlazorApp.Models;
using MediatR;

namespace BlazorApp.Services;

public class GetAirDataHandler : IRequestHandler<GetAwairDeviceDataQuery, List<AwairDeviceData>>
{
    private readonly AwairService _awairService;

    public GetAirDataHandler(AwairService awairService)
    {
        _awairService = awairService;
    }

    public async Task<List<AwairDeviceData>> Handle(GetAwairDeviceDataQuery request, CancellationToken cancellationToken)
    {
        await Task.Delay(500, cancellationToken);
        return await _awairService.GetAwairDeviceDataAsync();
    }
}