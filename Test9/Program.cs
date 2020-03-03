using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            List<CarPartsBase> usualCar = createCar(new UsualCarFactory(), data);

            List<CarPartsBase> hybridCar = createCar(new HybridCarFactory(), data);

            Console.WriteLine("create usual car");
            PrintCreationList(usualCar);
            Console.WriteLine();
            Console.WriteLine("create hybrid car");
            PrintCreationList(hybridCar);
            Console.ReadLine();
        }
        private static List<CarPartsBase> createCar(CarMakerFactoryBase factory, Data data)
        {
            List<CarPartsBase> result = new List<CarPartsBase>();
      
            result.Add(factory.CreateTin(data));
            result.Add(factory.CreateSeats(data));
            result.Add(factory.CreateWheels(data));
            result.Add(factory.CreateBattery());
            result.Add(factory.CreateCoolingSystem());
            result.Add(factory.CreateEngine());
            result.Add(factory.CreateLightingSystem());
            return result;
        }
        public static void PrintCreationList(List<CarPartsBase> carMakerList)
        {
            foreach (CarPartsBase carParts in carMakerList)
            {
                Console.WriteLine(carParts.ToString());
            }
        }
    }
}
