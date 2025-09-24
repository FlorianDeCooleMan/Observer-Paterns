using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    public class CurrentConditionDisplay : Observer
    {
        private float temperature;
        private float humidity;

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}°C and {humidity}% humidity");
        }
    }
}
