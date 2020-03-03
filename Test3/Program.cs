using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCarControl carcontrol = new RealCarControl();
            Car car = new Car();
            GetProxy(new CarControlProxy(), car );

            carcontrol.StartDrive(car);
            carcontrol.FinishDrive(car);
            carcontrol.IncreaseSpeed(car, 20);
            carcontrol.SlowedDown(car, 10);
            carcontrol.TurnLeft(car);
            carcontrol.TurnRight(car);


            Console.ReadLine();
        }
        static void GetProxy(IAnotherCarControl proxy, Car car)
        {
            Console.WriteLine(proxy.ShowFuelMode(car));
            Console.WriteLine(proxy.ShowLocation(car));
        }
    }
}
