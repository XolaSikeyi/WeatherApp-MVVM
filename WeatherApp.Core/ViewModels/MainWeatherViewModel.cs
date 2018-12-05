using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using WeatherApp.Core.Services;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using System.Windows.Input;

namespace WeatherApp.Core.ViewModels
{
    public class MainWeatherViewModel : MvxViewModel
    {
        private readonly IWeatherService _weatherService;
        private readonly ISystemCacheService _systemCache;
        private readonly IMvxNavigationService _navigationService;

        public MainWeatherViewModel(IWeatherService weatherService, ISystemCacheService systemCache, IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;
            _systemCache = systemCache;

            MyCommand = new MvxAsyncCommand(DoMyCommand, MyCommandCanExecute);
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                SetProperty(ref _city, value);
                MyCommand.RaiseCanExecuteChanged();
            }
        }

        public bool MyCommandCanExecute()
        {
            return !string.IsNullOrEmpty(City);
        }
        public MvxAsyncCommand MyCommand { get; }
        private async Task DoMyCommand()
        {
            try
            {
                var result = await _weatherService.GetWeather(City);
                if (result != null)
                {
                    _systemCache.WeatherDetails = result;
                   
                    await _navigationService.Navigate<WeatherDetailsViewModel>();
                }
            }
            finally { }

        }
    }
}

