using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2016
{
    public class WeatherFactory
    {
        public const string OPEN_WEATHER_MAP = "OPEN_WEATHER_MAP";
        public const string ANOTHER_SERVICE = "";
        public IWeatherDataService GetWeatherServices(string Service)
        {
            IWeatherDataService Option = null;

            if (Service.Equals(OPEN_WEATHER_MAP))
            {
                Option = OpenWeatherMap.Singleton();
            }
            // Here can be more Weather Services
            return Option;
        }
    }
}
