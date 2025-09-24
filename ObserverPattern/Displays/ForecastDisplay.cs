using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    public class ForecastDisplay : Observer
    {
        private string forecastMessage = "";

        public ForecastDisplay(WeatherData weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            if (temperature > 20)
                forecastMessage = "Wat een lekker weertje zeg";
            else if (temperature < 18)
                forecastMessage = "Het weer is wel een beetje koud";
            Display();
        }

        public void Display()
        {
            Console.WriteLine(forecastMessage);
        }
    }
}
