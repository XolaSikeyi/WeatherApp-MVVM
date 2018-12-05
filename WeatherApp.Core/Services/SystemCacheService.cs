using WeatherApp.Core.Services;

namespace WeatherApp.Core.Services
{
    public class SystemCacheService: ISystemCacheService
    {
        public WeatherInfo.RootObject WeatherDetails { get; set; }
    }
}