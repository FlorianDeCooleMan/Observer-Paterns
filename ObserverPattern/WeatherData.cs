using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private List<Observer> observers = new();

        public void RegisterObserver(Observer observer) => observers.Add(observer);
        public void RemoveObserver(Observer observer) => observers.Remove(observer);

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
}
