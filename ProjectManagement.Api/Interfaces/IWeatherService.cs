using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.Api.Models;

namespace ProjectManagement.Api.Interfaces
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}