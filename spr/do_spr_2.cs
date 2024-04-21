using System;
using System.Collections.Generic;

namespace CompositePattern
{
    interface Component
    {
        void Operation();
    }

    class Leaf : Component
    {
        public void Operation()
        {
            Console.WriteLine("Leaf operation");
        }
    }

    class Composite : Component
    {
        private List<Component> components = new List<Component>();

        public void Operation()
        {
            foreach (var component in components)
            {
                component.Operation();
            }
        }

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
