using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine
{
    //универснальный класс для создания машин
    public class CarCreator<T> : ICarCreator<T>
    {
        public CarCreator(T car)
        {
            this.car = car;
        }

        public T GetCar
        {
            get => car;
        }

        private T car;
    }
}
