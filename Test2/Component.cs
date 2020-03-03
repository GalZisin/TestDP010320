using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public abstract class Component
    {
        protected int number;
        protected string name;

        protected Component(int number, string name)
        {
            this.number = number;
            this.name = name;
        }
        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();
        public abstract int Sum();

        public abstract void Draw(string space);
        public int GetInt()
        {
            return this.number;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
