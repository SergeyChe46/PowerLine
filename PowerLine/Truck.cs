using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine
{
    public class Truck : BaseCar
    {
        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Capacity can't be less zero.");
                }

                else if (value > _maxCapacity)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Capacity can't be excessed.");
                }
                _capacity = value;
            }
        }

        public override float CalculatePathLengthWithCondition(int capacity)
        {
            if (capacity == 0)
            {
                return CalculatePathLength();
            }
            Capacity = capacity;
            float pathLengthLess = _lessForEachTwoHundreeds * (Capacity / 200);
            return CalculatePathLength() * pathLengthLess;
        }

        private int _capacity;
        private readonly float _lessForEachTwoHundreeds = 0.04f; 
        private readonly int _maxCapacity = 3000;

    }
}
