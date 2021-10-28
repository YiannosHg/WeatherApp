using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class TemperatureUnit
    {
        public bool tempC { get; }
        public bool tempF { get; }

        // Getters implementation
        bool getTempC() { return tempC; }
        bool getTempF() { return tempF; }
    }
}
