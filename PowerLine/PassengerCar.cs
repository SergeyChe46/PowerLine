using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine
{
    public class PassengerCar : BaseCar
    {
        public int PassengerQuantity
        {
            get => _passengerQuantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Wrong value");
                }

                else if(value > _maxPassengerQuantity)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Too much passengers fot this car");
                }

                _passengerQuantity = value;
            }
        }
        
        public override float CalculatePathLengthWithCondition(int passengerQuantity)
        {
            //здесь подразумевается, что водитель не считается пассажиром,
            //и, соответсвенно, не увеличивает расход топлива
            if(passengerQuantity == 0)
            {
                return CalculatePathLength();
            }
            //это запас хода с допустимым количеством пассажиров
            PassengerQuantity = passengerQuantity;
            float pathLengthLess = _lessForEachPassenger * (float)PassengerQuantity;
            return CalculatePathLength() * pathLengthLess;
        }

        private int _passengerQuantity;
        private const float _lessForEachPassenger = 0.06f;
        private readonly int _maxPassengerQuantity = 4;
    }
}
