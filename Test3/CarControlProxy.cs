using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class CarControlProxy: IAnotherCarControl
    {
        public CarControlProxy()
        {
        }

        public string ShowFuelMode(Car c)
        {
            IAnotherCarControl carControl = new RealCarControl();
            return carControl.ShowFuelMode(c);
        }

        public string ShowLocation(Car c)
        {
            IAnotherCarControl carControl = new RealCarControl();
            return carControl.ShowLocation(c);
        }

    }
}
