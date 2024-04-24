using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spr2
{
    public abstract class Autobus { }
    public class Przystanek
    {
        bool czyNaRzadanie;
        bool czyPosiadaBiletomat;
        bool czyPosiadaZadaszenie;
        List<Autobus> ListaAutobusow;
    }
    class PunktCentralny : Przystanek
    {

    }
    class Petla : Przystanek
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
