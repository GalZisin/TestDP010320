using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game-Computer creation");
            new GameComputer().Run();

            Console.WriteLine();

            Console.WriteLine("Office-Computer creation");
            new OfficeComputer().Run();

            Console.WriteLine();

            Console.WriteLine("Living room-Computer creation");
            new LivingRoomComputer().Run();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
