using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float maxTemp = float.MinValue;
        private float minTemp = float.MaxValue;
        private float sumTemp = 0f;
        private int numReadings = 0;

        public StatisticsDisplay(WeatherData weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            sumTemp += temperature;
            numReadings++;

            if (temperature > maxTemp)
                maxTemp = temperature;
            if (temperature < minTemp)
                minTemp = temperature;
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {(numReadings > 0 ? sumTemp / numReadings : 0)}/{maxTemp}/{minTemp}");
        }
    }
}
