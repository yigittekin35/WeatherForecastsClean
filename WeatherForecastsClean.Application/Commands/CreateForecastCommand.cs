using MediatR;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Application.Commands
{
    public class CreateForecastCommand : IRequest<WeatherForecast>
    {
        public WeatherForecast NewForecast { get; set; }
    }
}
