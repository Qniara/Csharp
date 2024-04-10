using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_10_04_2024
{
    public interface Wezel
    {
        public string nazwa { get; set; }
        public void Wyswietl()
        {
            Console.WriteLine(nazwa);
        }
    }
    class Plik : Wezel
    {
        public string nazwa { get; set; }
        public void Wyswietl()
        {
            Console.WriteLine(nazwa);
        }
    }
    class Katalog : Wezel
    {
        List<Wezel> wezly = new List<Wezel>();
        public string nazwa { get; set; }
        public void Wyswietl()
        {
            Console.WriteLine(nazwa);
            foreach(var item in wezly)
            {
                Console.WriteLine("\n--");
                item.Wyswietl();
            }
        }
        void dodaj(Wezel w)
        {
            wezly.Add(w);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Plik z1 = new Plik();
            z1.nazwa = "f1";
            Plik z2 = new Plik();
            z2.nazwa = "f2";
            Katalog k1 = new Katalog();
            k1.nazwa = "zdjecia";
            k1.dodaj(z1);
            k1.dodaj(z2);
            Katalog d1 = new Katalog();
            d1.nazwa = "Dysk";
            d1.dodaj(k1);
            d1.Wyswietl();
            Console.ReadLine();

        }
    }
}
-----------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_10_04_2024
{
    class WashingMaschine
    {
        Washing w;
        Spinning s;
        Rinsing r;
        public void StartWashing() { }
        public void Piesz(Washing w, Rinsing r, Spinning s)
        {
            this.w = w;
            this.s = s;
            this.r = r;
        }
    }
    class Client
    {
        WashingMaschine wm;
        public void setWashingMaschine(WashingMaschine wmm)
        {
            wm = wmm;
        }
    }
    class Washing : WashingMaschine
    {
        public void Wash() { }
    }
    class Rinsing
    {
        public void Rinse() { }
    }
    class Spinning
    {
        public void Spin() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
