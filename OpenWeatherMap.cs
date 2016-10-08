using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProject2016
{
    public class OpenWeatherMap : IWeatherDataService
    {
        public WeatherData data;
        /// <summary>
        /// Singleton init
        /// </summary>
        private static OpenWeatherMap instance = null;
        private static readonly object padlock = new object();
        private OpenWeatherMap() { }
        public static OpenWeatherMap Singleton()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OpenWeatherMap();
                    }
                }
            }
            return instance;
        }
        // End Singleton

        public WeatherData GetWeatherData(Location location)
        {
            XMLParse(location.Name);
            return this.data;

        }
        public void XMLParse(string location)
        {
            try
            {
                Location loc = new Location("temp");
                string userKEY = "6ce15a07fe92882f15b450340b3c025c";
                XDocument xdoc = XDocument.Load("http://api.openweathermap.org/data/2.5/weather?q=" + location + "&mode=xml&appid=" + userKEY);
                xdoc.Descendants("current").Select(p => new
                {
                    id = p.Element("city").Attribute("id").Value,
                    coordA = p.Element("city").Element("coord").Attribute("lon").Value,
                    coordB = p.Element("city").Element("coord").Attribute("lat").Value,
                    name = p.Element("city").Attribute("name").Value,
                    country = p.Element("city").Element("country").Value,
                    rise = p.Element("city").Element("sun").Attribute("rise").Value,
                    set = p.Element("city").Element("sun").Attribute("set").Value,
                    temp = p.Element("temperature").Attribute("value").Value,
                    tempMin = p.Element("temperature").Attribute("min").Value,
                    tempMax = p.Element("temperature").Attribute("max").Value,
                    tempUnit = p.Element("temperature").Attribute("unit").Value,
                    humidity = p.Element("humidity").Attribute("value").Value,
                    pressure = p.Element("pressure").Attribute("value").Value,
                    windSpeed = p.Element("wind").Element("speed").Attribute("value").Value,
                    windDir = p.Element("wind").Element("direction").Attribute("name").Value,
                    clouds = p.Element("weather").Attribute("value").Value,
                }).ToList().ForEach(p =>
                {
                    loc.Id = p.id;
                    loc.CoordA = p.coordA;
                    loc.CoordB = p.coordB;
                    loc.Name = p.name;
                    loc.Country = p.country;
                    loc.Sunrise = p.rise;
                    loc.Sunset = p.set;
                    loc.Temp = p.temp;
                    loc.TempMin = p.tempMin;
                    loc.TempMax = p.tempMax;
                    loc.TempUnit = p.tempUnit;
                    loc.Humidity = p.humidity;
                    loc.Pressure = p.pressure;
                    loc.WindSpeed = p.windSpeed;
                    loc.WindDir = p.windDir;
                    loc.Clouds = p.clouds;
                });
               this.data = new WeatherData(loc);
            }
            catch (WeatherExceptions e)
            {
                Console.WriteLine(e.Source);
            }
        }
    }
}
