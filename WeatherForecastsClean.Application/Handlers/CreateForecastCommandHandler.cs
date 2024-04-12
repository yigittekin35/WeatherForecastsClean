using MediatR;
using WeatherForecastsClean.Application.Commands;
using WeatherForecastsClean.Core;
using WeatherForecastsClean.Infrastructure;

namespace WeatherForecastsClean.Application.Handlers
{
    public class CreateForecastCommandHandler : IRequestHandler<CreateForecastCommand, WeatherForecast>
    {
        private readonly DataContext _ctx;

        public CreateForecastCommandHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<WeatherForecast> Handle(CreateForecastCommand request, CancellationToken cancellationToken)
        {
            await _ctx.Forecasts.AddAsync(request.NewForecast);
            await _ctx.SaveChangesAsync();

            return request.NewForecast;
        }
    }
}
