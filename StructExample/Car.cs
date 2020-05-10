using StructExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct Wheel
    {
        public int wheelSize;
        public EnumWheelCompany wheelCompany;
    }
    public struct Radio
    {
        public EnumFrequency frequencyType;
        public string company;
    }
    public struct Gearbox
    {
        public EnumGears numOfGears;
        public string gearPlace;
    }
    public  class Car
    {
        int carID;
        protected EnumCarType carType;
        private Nullable<Wheel> wheel; //wheel is nullable = meanwhile its value is NULL
        Nullable<Radio> radio;
        Nullable<Gearbox> gearbox;
        public Car(int carID)
        {
            
            
            this.carID = carID;
        }


        public Car (int carID,  Wheel wheel,Radio radio, Gearbox box)        {
            this.wheel = wheel;
            this.radio = radio;
            this.carID = carID;
           
            this.gearbox = box;
        }

        public Nullable<Wheel> Wheel { get => wheel; set => wheel = value; }
        public Nullable<Radio> Radio { get => radio; set => radio = value; }
        public EnumCarType CarType { get => carType; set => carType = value; }
        //
        //
        //
        //

    }
}
