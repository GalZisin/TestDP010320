using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public interface ICarControl
    {
        void StartDrive(Car c);
        void FinishDrive(Car c);
        void IncreaseSpeed(Car c, int speed);
        void SlowedDown(Car c, int speed);
        void TurnRight(Car c);
        void TurnLeft(Car c);
        string ShowFuelMode(Car c);
        string ShowLocation(Car c);
    }
}
