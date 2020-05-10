using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public class MediumCar : Car
    {
        public MediumCar(int carID, Wheel wheel, Radio radio, Gearbox box) : base(carID, wheel, radio, box)
        {
            this.carType = EnumCarType.MediumCar;
        }
    }
}
