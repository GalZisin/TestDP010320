using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9
{
    public class UsualCarFactory : CarMakerFactoryBase
    {
        public override CarSeatsBase CreateSeats(Data data)
        {
            return new UsualCarSeats();
        }

        public override CarTinBase CreateTin(Data data)
        {
            return new UsualCarTin();
        }

        public override CarWheelsBase CreateWheels(Data data)
        {
            return new UsualCarWheels();
        }
        public override Engine CreateEngine()
        {
            return new UsualCarEngine();
        }
        public override CoolingSystem CreateCoolingSystem()
        {
            return new UsualCarCoolingSystem();
        }
        public override LightingSystem CreateLightingSystem()
        {
            return new UsualCarLightingSystem();
        }
        public override Battery CreateBattery()
        {
            return new UsualCarBattery();
        }
    }
}
