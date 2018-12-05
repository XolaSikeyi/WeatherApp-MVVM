using System;
namespace WeatherApp.Core.Presentation
{
    public class WeatherDetail
    {
        public WeatherDetail(string title, string value)
        {
            Title = title;
            Value = value;
        }

        public string Title { get; }
        public string Value { get; }
    }

}
