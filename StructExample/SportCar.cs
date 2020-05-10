using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public class SportCar : Car
    {
        public SportCar(int carID) : base(carID)
        {
            this.carType = EnumCarType.TaxyCar;
        }

        public SportCar(int carID,  Wheel wheel, Radio radio, Gearbox box) : base(carID,  wheel, radio, box)
        {
            this.carType = EnumCarType.TaxyCar;
        }
    }
}
