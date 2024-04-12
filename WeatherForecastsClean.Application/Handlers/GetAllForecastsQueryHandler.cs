using MediatR;
using Microsoft.EntityFrameworkCore;
using WeatherForecastsClean.Application.Queries;
using WeatherForecastsClean.Core;
using WeatherForecastsClean.Infrastructure;

namespace WeatherForecastsClean.Application.Handlers
{
    public class GetAllForecastsQueryHandler : IRequestHandler<GetAllForecastsQuery, List<WeatherForecast>>
    {
        private readonly DataContext _ctx;
        public GetAllForecastsQueryHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<WeatherForecast>> Handle(GetAllForecastsQuery request, CancellationToken cancellationToken)
        {
            return await _ctx.Forecasts.ToListAsync(cancellationToken);
        }
    }
}
