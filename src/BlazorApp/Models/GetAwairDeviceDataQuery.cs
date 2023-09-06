using MediatR;

namespace BlazorApp.Models;

public class GetAwairDeviceDataQuery : IRequest<List<AwairDeviceData>>;