using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9
{
    public abstract class CarMakerFactoryBase
    {
        public abstract CarTinBase CreateTin(Data data);
        public abstract CarSeatsBase CreateSeats(Data data);
        public abstract CarWheelsBase CreateWheels(Data data);
        public abstract Engine CreateEngine();
        public abstract CoolingSystem CreateCoolingSystem();
        public abstract LightingSystem CreateLightingSystem();
        public abstract Battery CreateBattery();

    }
}
