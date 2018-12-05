using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using MvvmCross.ViewModels;
using WeatherApp.Core.ViewModels;
using WeatherApp.Core.Services;
using MvvmCross.IoC;

namespace WeatherApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

         
            Mvx.IoCProvider.RegisterType<IWeatherService, WeatherService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ISystemCacheService, SystemCacheService>();
            
            RegisterAppStart<MainWeatherViewModel>();

        }
    }
}
