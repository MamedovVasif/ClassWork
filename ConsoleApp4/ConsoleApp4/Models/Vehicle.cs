using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    

   abstract class Vehicle
    {
        private int _DriveTime;
        private int _DrivePath;
        public int DriveTime { get { return _DriveTime; } set { if (value > 0) { DriveTime = value; } } }
        public int DrivePath { get { return _DrivePath; } set { if (value > 0) { DrivePath = value; } } }
   public void AvarageSpeed()
        {
            Console.WriteLine($"Gedilen yol:{DrivePath/DriveTime}km/saatdir");
        }
    }
    interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public int FuelType { get; set; }
        public void LeftFuelAmmount()
        {
            
        }
    }
    interface IIWheel
    {
        public int WheelThickness { get; set; }
    }
    interface IITransmisson
    {
        public int TransmissionKind { get; set; }
    }
    
}
