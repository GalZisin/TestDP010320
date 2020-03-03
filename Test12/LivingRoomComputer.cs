using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    public class LivingRoomComputer : ComputerTemplateBase
    {
        protected override void AddGraphicsCard()
        {
            Console.WriteLine("Add Strong Graphics Card...");
        }

        protected override void AddMemory()
        {
            base.AddMemory();
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Add Thin Mother Board...");
        }

        protected override void AddProcessor()
        {
            Console.WriteLine("Add Medium Processor...");
        }

        protected override void CreateEnclosure()
        {
            Console.WriteLine("Add Thin Enclosure...");
        }
    }
}
