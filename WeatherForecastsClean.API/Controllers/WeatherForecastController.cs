using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastsClean.Application.Commands;
using WeatherForecastsClean.Application.Queries;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllForecastsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] WeatherForecast forecast)
        {
            var command = new CreateForecastCommand()
            {
                NewForecast = forecast
            };

            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
