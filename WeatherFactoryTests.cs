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
    public class WeatherFactoryTests
    {
        [TestMethod()]
        public void GetWeatherServicesTest()
        {
            String name = "FinalProject2016.OpenWeatherMap";
            WeatherFactory f = new WeatherFactory();
            IWeatherDataService Service = f.GetWeatherServices(WeatherFactory.OPEN_WEATHER_MAP);
            Assert.AreEqual(Service.ToString(), name);
        }
    }
}