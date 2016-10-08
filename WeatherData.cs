using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2016
{
    public class WeatherData
    {
        public Location loc;

        public WeatherData(Location location)
        {
            this.loc = location;
        }

        public void PrintData()
        {

            Console.WriteLine(@"CITY INFO:
========================
    Id:           {0}
    Name:         {1}
    Geo Coord:    [{2},{3}]
    Country:      {4}
    Sunrise:      {5}
    Sunset:       {6}

Temperature -
    Current:      {7}
    Min:          {8}
    Max:          {9}
    Unit:         {10}

Humidity:         {11}
Pressure:         {12}

Wind -
    Speed:        {13}
    Direction:    {14}
    Cloud Status: {15}"
        , loc.Id, loc.Name, loc.CoordA, loc.CoordB, loc.Country, loc.Sunrise, loc.Sunset,
        loc.Temp, loc.TempMin, loc.TempMax, loc.TempUnit, loc.Humidity,
        loc.Pressure, loc.WindSpeed, loc.WindDir, loc.Clouds);
            Console.ReadLine();
        }
    }
}
