
namespace WeatherApp.Core.Services
{
    public interface ISystemCacheService
    {
        WeatherInfo.RootObject WeatherDetails { get; set; }
    }
}
