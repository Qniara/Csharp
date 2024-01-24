//NIE CAŁE, DO DOKONCZENIA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class wierzcholek
    {
        List<int> Poloczenia = new List<int>();
    }
    class Graf
    {
        public Graf(int n)
        {
            for(int i=0; i < n; i++)
            {
                Wierzcholki.Add(new wierzcholek());
            }
        }
        List<wierzcholek> Wierzcholki = new List;
        static void DodajKrawedz(int w, params int[] polacz)
        {
            foreach(var item in polacz)
            {
                Wierzcholki[w].DodajPolaczenie(item);
            }
        }
    }

    //wypisz krawedzie 
    public void WypiszKrawedzie(int w)
    {
        Wierzcholki[w].WypiszPoloczenia();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Graf g = new Graf();
            g.DodajKrawedz(0, 1, 2);
            g.DodajKrawedz(2, 0, 3, 5);
            g.DodajKrawedz(3, 1, 2, 5);
            g.DodajKrawedz(5, 2, 3);
            for(int i = 0; i < 6; i++)
            {
                g.WypiszKrawedzie(i);
            }

            Console.ReadLine();
        }
    }
}
