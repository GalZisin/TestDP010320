using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
           
            s.push(3);
            s.Pop();
            s.push(5);
            s.push(7);
            s.push(19);
            s.push(4);
            s.push(20);
            s.Pop();
            s.push(2);

            //s.GetMax();
            //s.GetMax();
            //s.Pop();
            //s.GetMax();
            //s.Pop();
            //s.Peek();

            Console.ReadLine();
        }
    }
}
