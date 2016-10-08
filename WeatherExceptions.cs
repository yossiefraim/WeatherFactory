using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2016
{
    public class WeatherExceptions : Exception
    {
        public WeatherExceptions() { }

        public WeatherExceptions(string message) : base(message) {
            Console.WriteLine("Exception Error - " + message);
        }
    }
}
