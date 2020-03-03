using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class RealCarControl: ICarControl, IAnotherCarControl
    {
        protected int driverSpeed = 80;
        public void StartDrive(Car c)
        {
            Console.WriteLine("Start driving.....");
        }
        public void FinishDrive(Car c)
        {
            Console.WriteLine("Finish driving.....");
        }
        public void IncreaseSpeed(Car c, int speed)
        {
            driverSpeed += speed;
        }
        public void SlowedDown(Car c, int speed)
        {
            driverSpeed -= speed;
        }
        public void TurnRight(Car c)
        {
            Console.WriteLine("Turn right.....");
        }
        public void TurnLeft(Car c)
        {
            Console.WriteLine("Turn left.....");
        }
        public string ShowFuelMode(Car c)
        {
            return "Show fuel mode.....";
        }
        public string ShowLocation(Car c)
        {
            return "Show location.....";
        }
    }
}
    

