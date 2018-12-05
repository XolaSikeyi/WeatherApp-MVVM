using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Core.Enums;

namespace WeatherApp.Core.Services
{
    public interface IPreferenceService
    {
        void SaveValue(PreferenceType key, string value);
        string GetValue(PreferenceType key);
    }
}
