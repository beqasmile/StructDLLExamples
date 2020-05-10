using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier x = new Soldier();
            x.id = 6;
            x.name = "Test Soldier";
            x.gender = "Male";

            Car car1=new Car(222, EnumCarType.Bus);

            Car car2 = new Car(333, EnumCarType.SportCar);

            EnumCarType enumCarType = EnumCarType.MediumCar;


            switch (car1.CarType)
            {
                case EnumCarType.Bus:

                    break;
                case EnumCarType.MediumCar:
                    break;
                case EnumCarType.SmallCar:
                    break;
                case EnumCarType.SportCar:
                    break;
                case EnumCarType.TaxyCar:
                    break;
            }

                
        }
    }
}
