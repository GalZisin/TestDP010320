using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Leaf : Component
    {
        public Leaf(int number,string name) : base(number,name)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override int Sum()
        {
            return this.number;
        }
        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name);
        }
    }
}
