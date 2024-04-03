using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_03_04_2024
{
    abstract class Pracownik { }
    partial class Kosmetyczka : Pracownik { }
    partial class Fryzjerka : Pracownik { }
    partial class Manikirzystka : Pracownik { }
    class Lokal
    {
        public string Adres { get; set; }
        public string NrTel { get; set; }
        public double StawkaCzynszu { get; set; }
    }
    class Wyposazenie
    {
        public string Nazwa { get; set; }
    }
    class SalonUrody
    {
        private Lokal lokal;
        List<Pracownik> LP = new List<Pracownik> { };
        List<Wyposazenie> LW = new List<Wyposazenie> { };
        public void SetLokal(Lokal l)
        {
            this.lokal = l;
        }
        public void DodajPracownika(Pracownik pracownik)
        {
            LP.Add(pracownik);
        }
        public void DodajWyposazenie(Wyposazenie wyposazenie)
        {
            LW.Add(wyposazenie);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kosmetyczka k1 = new Kosmetyczka();
            Kosmetyczka k2 = new Kosmetyczka();
            Fryzjerka f1 = new Fryzjerka();
            Fryzjerka f2 = new Fryzjerka();
            Manikirzystka m1 = new Manikirzystka();

            Lokal l = new Lokal();
            l.Adres = "Seattle";
            l.NrTel = "420";
            l.StawkaCzynszu = 2137.69;

            Wyposazenie w1 = new Wyposazenie();
            w1.Nazwa = "Szampon";
            Wyposazenie w2 = new Wyposazenie();
            w2.Nazwa = "Grzebien";
        }
    }
}
