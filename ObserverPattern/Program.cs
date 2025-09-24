using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);

            Console.WriteLine("Observer Pattern Example\n");

            weatherData.SetMeasurements(10, 65, 30);
            weatherData.RemoveObserver(forecastDisplay);
            Console.WriteLine("\nForecastDisplay is now unsubscribed.\n");
            weatherData.SetMeasurements(1000, 650, 300); 

        }
    }
}