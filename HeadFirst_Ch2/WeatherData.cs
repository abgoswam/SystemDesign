using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_Ch2
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temp;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(temp, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            var item = observers.Find(x => x.Id == o.Id);
            if (item != null)
                observers.Remove(item);
        }

        private void MeasurementsChanged()
        {
            this.NotifyObservers();
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            this.MeasurementsChanged();
        }
    }
}
