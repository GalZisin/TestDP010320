using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9
{
    public class HybridCarFactory : CarMakerFactoryBase
    {
        public override CarSeatsBase CreateSeats(Data data)
        {
            return new HybridCarSeats();
        }

        public override CarTinBase CreateTin(Data data)
        {
            return new HybridCarTin();
        }

        public override CarWheelsBase CreateWheels(Data data)
        {
            return new HybridCarWheels();
        }
        public override Engine CreateEngine()
        {
            return new UsualCarEngine();
        }
        public override CoolingSystem CreateCoolingSystem()
        {
            return new HybridCarCoolingSystem();
        }
        public override LightingSystem CreateLightingSystem()
        {
            return new HybridCarLightingSystem();
        }
        public override Battery CreateBattery()
        {
            return new HybridCarBattery();
        }
    }
}
