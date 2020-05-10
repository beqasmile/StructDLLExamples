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
        EnumCarType carType;
        Wheel wheel;
        Radio radio;
        Gearbox gearbox;
        public Car(int carID, EnumCarType carType)
        {
            this.CarType = carType;
            
            this.carID = carID;
        }
        public Car (int carID, EnumCarType carTyp, Wheel wheel,Radio radio, Gearbox box)
        {
            this.wheel = wheel;
            this.radio = radio;
            this.carID = carID;
            this.CarType = carTyp;
            this.gearbox = box;
        }

        public Wheel Wheel { get => wheel; set => wheel = value; }
        public Radio Radio { get => Radio1; set => Radio1 = value; }
        public Radio Radio1 { get => radio; set => radio = value; }
        public EnumCarType CarType { get => carType; set => carType = value; }
        //
        //
        //
        //

    }
}
