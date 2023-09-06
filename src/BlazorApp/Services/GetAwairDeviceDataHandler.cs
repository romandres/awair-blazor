using BlazorApp.Models;
using MediatR;

namespace BlazorApp.Services;

public class GetAwairDeviceDataHandler : IRequestHandler<GetAwairDeviceDataQuery, List<AwairDeviceData>>
{
    private readonly AwairService _awairService;

    public GetAwairDeviceDataHandler(AwairService awairService)
    {
        _awairService = awairService;
    }

    public async Task<List<AwairDeviceData>> Handle(GetAwairDeviceDataQuery request, CancellationToken cancellationToken)
    {
        return await _awairService.GetAwairDeviceDataAsync(cancellationToken);
    }
}