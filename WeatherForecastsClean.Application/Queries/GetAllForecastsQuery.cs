using MediatR;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Application.Queries
{
    public class GetAllForecastsQuery : IRequest<List<WeatherForecast>>
    {

    }
}
