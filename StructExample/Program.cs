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

            Car car1=new MediumCar(222);

            if (true)
            {
                Console.WriteLine(car1.Wheel.Value);
            }


            Car car2 = new SportCar(333);

            EnumCarType enumCarType = EnumCarType.MediumCar;
            EnumCarType enumCarType2 = EnumCarType.Bus;
            if (enumCarType2>enumCarType)
            {
                Console.WriteLine(EnumCarType.Bus + " is bigger");
            }
            else
            {
                Console.WriteLine(EnumCarType.MediumCar + " is bigger");
            }


            Wheel wheel = new Wheel();
            wheel.wheelCompany = Enums.EnumWheelCompany.Alliance;
            wheel.wheelSize = 3;

            Radio radio = new Radio();
            radio.frequencyType = Enums.EnumFrequency.FM;
            radio.company = "GALGALAZ";


            Gearbox gearbox = new Gearbox();
            gearbox.numOfGears = Enums.EnumGears.FiveGears;

            Car car3 = new SportCar(8,  wheel, radio, gearbox);

            Console.WriteLine(EnumCarType.SportCar);


                        

            if (car3.Wheel!=null)
            {
                Console.WriteLine(car3.Wheel.Value);

            }

            if (car3.Wheel.HasValue )
            {
                Console.WriteLine(car3.Wheel.Value);

            }

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

            

            int? a = null; // nullable a declaration
            
            a = 5; // nullable a set value

            Console.WriteLine(a.Value); // nullable a get value
            bool isSportCar;

            if (car1.CarType == EnumCarType.SportCar)
            {
                isSportCar = true;
            }
            else
            {
                isSportCar = false;
            }

            bool isSportCarShort = car1.CarType == EnumCarType.SmallCar ?  true : false ;

            Console.ReadLine();
        }
    }
}
