using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Component root = new Composite(1);
            //Composite left = new Composite(1);
            //Component right = new Composite(1);
            //root.AddChild(2);
            //root.AddChild(2);

            Component root = new Composite(10,"main");
            Component c1 = new Leaf(6,"c1");
            Component c2 = new Leaf(4, "c2");
            Component c3 = new Leaf(2, "c3");
            Component c4 = new Leaf(8, "c4");
            root.AddChild(c1);
            root.AddChild(c2);
            root.AddChild(c3);
            root.AddChild(c4);

            Component container1 = new Composite(10, "comtainer1");
            Component c5 = new Leaf(12, "c5");
            Component c6 = new Leaf(4, "c6");
            container1.AddChild(c5);
            container1.AddChild(c6);

            root.AddChild(container1);

            //Component container1 = new Composite(3, "Container 1");
            //Component circle2 = new Leaf(2, "Circle 1");
            //Component circle3 = new Leaf(1, "Circle 2");
            //container1.AddChild(circle2);
            //container1.AddChild(circle3);

            //root.AddChild(container1);

            //Component container2 = new Composite(16, "Container of triangles");
            //Component t1 = new Leaf(18,"Triangle 1");
            //Component t2 = new Leaf(20, "Triangle 2");
            //container2.AddChild(t1);
            //container2.AddChild(t2);

            //root.AddChild(container2);

            root.Draw(""); // without recurrsion
            //Draw(root, ""); // with recusrion
            Console.WriteLine();
            Console.WriteLine("The sum of all values in tree: "+ root.Sum());

            Console.WriteLine();
            Console.WriteLine($"Whether all numbers are even: { CheckEven(root).ToString()}");
     

            Console.ReadLine();
        }

        static bool CheckEven(Component c)
        {
            
            if(c.GetInt() % 2 != 0)
            {
                return false;
            }
            if (c.GetChilds() == null)
                return true;

            foreach (Component child in c.GetChilds())
            {
                if (!CheckEven(child))
                {
                    return false;
                }
            
            }
            return true;
        }
        // recursion
        static void Draw(Component c, string space)
        {
            Console.WriteLine(space + c.GetName());

            if (c.GetChilds() == null)
                return;

            foreach (Component child in c.GetChilds())
            {
                Draw(child, space + "    ");
            }
        }
    }
}