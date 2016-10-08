using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2016
{
    public class Location
    {
        private string _id, _name, _coordA, _coordB, _country, _sunrise, _sunset, _temp, _tempMin, _tempMax, _tempUnit;
        private string _humidity, _pressure, _windSpeed, _windDir, _clouds;

        public Location(string name)
        {
            Name = name;
        }

        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string CoordA { get { return _coordA; } set { _coordA = value; } }
        public string CoordB { get { return _coordB; } set { _coordB = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public string Sunrise { get { return _sunrise; } set { _sunrise = value; } }
        public string Sunset { get { return _sunset; } set { _sunset = value; } }
        public string Temp { get { return _temp; } set { _temp = value; } }
        public string TempMin { get { return _tempMin; } set { _tempMin = value; } }
        public string TempMax { get { return _tempMax; } set { _tempMax = value; } }
        public string TempUnit { get { return _tempUnit; } set { _tempUnit = value; } }
        public string Humidity { get { return _humidity; } set { _humidity = value; } }
        public string Pressure { get { return _pressure; } set { _pressure = value; } }
        public string WindSpeed { get { return _windSpeed; } set { _windSpeed = value; } }
        public string WindDir { get { return _windDir; } set { _windDir = value; } }
        public string Clouds { get { return _clouds; } set { _clouds = value; } }
    }
}
