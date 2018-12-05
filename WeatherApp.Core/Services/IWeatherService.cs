using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Services
{
    public interface IWeatherService
    {
       Task<WeatherInfo.RootObject> GetWeather(string cityName);
    }
}