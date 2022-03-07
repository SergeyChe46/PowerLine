using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine
{
    public abstract class BaseCar
    {
        public string CarType { get; set; }
        public float CurrentFuelVolume
        {
            get => _fuelTankVolume;
            set
            {
                if (value < 0)
                {
                    _fuelTankVolume = 0;
                }
                _fuelTankVolume = value;
            }
        }
        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Speed can't be less zero");
                }
                _speed = value;
            }
        }
        public float AvgFuelCost
        {
            //для примера
            get => 10;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can't be negative");
                }
                if (value == 0)
                {
                    throw new DivideByZeroException();
                }
            }
        }

        //расстояние на количестве топлива
        public float CalculatePathLength()
        {
            return CurrentFuelVolume / AvgFuelCost;
        }

        public string CalculateTimeToDestination(float pathLength)
        {
            TimeSpan span = TimeSpan.FromHours(pathLength / Speed);

            return string.Format("{0}:{2:00}:{2:00}", 
                (int)span.TotalHours, span.Minutes, span.Seconds);
        }

        public abstract float CalculatePathLengthWithCondition(int condition);

        private float _fuelTankVolume;
        private float _speed;
    }
}
