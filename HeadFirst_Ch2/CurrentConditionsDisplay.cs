using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_Ch2
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temp;
        private float _pressure;
        private ISubject _weatherData;

        public string Id { get; }

        public CurrentConditionsDisplay(string id, ISubject weatherData)
        {
            Id = id;
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Temp : {1} Pressure : {2}", Id, _temp, _pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this._temp = temp;
            this._pressure = pressure;
            Display();
        }
    }
}
