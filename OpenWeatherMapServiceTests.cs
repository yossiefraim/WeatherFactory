using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2016.Tests
{
    [TestClass()]
    public class OpenWeatherMapServiceTests
    {
        [TestMethod()]
        public void GetWeatherDataTest()
        {
            String name = "Tel Aviv District";
            WeatherFactory f = new WeatherFactory();
            IWeatherDataService Service = f.GetWeatherServices(WeatherFactory.OPEN_WEATHER_MAP);
            WeatherData data = (WeatherData)Service.GetWeatherData(new Location("tel-aviv"));
            Console.WriteLine(name + " - " + data.loc.Name);
            Assert.AreEqual(data.loc.Name, name);
        }

        [TestMethod()]
        public void SingletonTest()
        {
            WeatherFactory f = new WeatherFactory();
            IWeatherDataService Service = f.GetWeatherServices(WeatherFactory.OPEN_WEATHER_MAP);
            IWeatherDataService Service2 = f.GetWeatherServices(WeatherFactory.OPEN_WEATHER_MAP);
            Assert.AreEqual(Service.GetHashCode(),Service2.GetHashCode());
        }
    }
}