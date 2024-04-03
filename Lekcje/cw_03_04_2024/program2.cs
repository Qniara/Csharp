using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_03_04_2024_2
{
    class Component
    {
        public void Operation() { }
    }
    class Leaf : Component
    {
        public void Operation() { }
    }
    abstract class Composite : Component
    {
        public List<Component> components = new List<Component>();
        public override void Operation() { }
        public void Add() { }
        public void Remove() { }
        public void GetChild() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
