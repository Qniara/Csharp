using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad.1
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0) {
                Console.WriteLine("TAK");
            }
            else {
                Console.WriteLine("Nie");
            };
            //Zad.2
            int b = int.Parse(Console.ReadLine());
            if (b>99 && b>999 && b% 17 == 0) {
                ;
                Console.WriteLine("Tak");
            }
            else {
                Console.WriteLine("Nie");
            }
            //Zad.3
            int wiek = int.Parse(Console.ReadLine());
            if (wiek>17)
            {
                Console.WriteLine("Jestes pelnoletni");
            }
            else
            {
                Console.WriteLine("Nie jestes pelnoletni");
            }
            //Zad.4
            int waga = int.Parse(Console.ReadLine());
            if (waga<=20)
            {
                Console.WriteLine("Mozesz wjechac");
            }
            else
            {
                Console.WriteLine("Nie wjezdzaj");
            }
            //Zad.5
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if ((c<e && e<d) || )
        }
    }
}
