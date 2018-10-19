using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_Ch2
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay("CurrentConditions", weatherData);

            weatherData.SetMeasurements(10, 20, 30);
            weatherData.SetMeasurements(20, 30, 40);
        }
    }
}
