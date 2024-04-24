using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spr
{
    interface Robotny
    {
        string Robota { get; set;  }
        void planuj();
        void dzialaj();
    }
    public class Rekin : Robotny
    {
        string imie;
        string nazwisko;
    }
    class Leszcz : Robotny
    {
        string imie;
        string odmiana;
        void WymyslajWymowki() { }
        void Czekaj() { }
        void Udawaj() { }
    }
    public abstract class Gracz : Robotny
    {
        string imie;
        int poziom;
        void ideGrac() { }
        void jem() { }
        bool wydalam()
        {
            return false;
        }
        public abstract char znowIdeGrac();
    }
    public abstract class Klasa :Teknikum
    {
        string NumerKlasy;
        List<Robotny> ListaRobotnych;
        public abstract void dodajDoListy();
    }
    public class Teknikum
    {
        private string nazwa { get; set; }
        public string PodajNazwe(string nazwa)
        {
            return nazwa;
        }
    }
    class Szkola : Teknikum
    {
        string kraj;
        void szkola() { }
        void StworzSzkole() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
