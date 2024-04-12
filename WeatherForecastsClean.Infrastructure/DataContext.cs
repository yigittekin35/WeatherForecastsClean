using Microsoft.EntityFrameworkCore;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<WeatherForecast> Forecasts { get; set; }
    }
}
