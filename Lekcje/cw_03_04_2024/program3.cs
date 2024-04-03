using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_03_04_2024_3
{
    public class Prezes { }
    class DyrektorFinansow : Prezes { }
    class DyrektorLogistyki : Prezes { }
    class Ksiegowa : DyrektorFinansow { }
    class Spedytor : DyrektorLogistyki { }
    class Magazynier : DyrektorLogistyki { }
    class Kierowca : DyrektorLogistyki { }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
/*
 * Zakoduj osoby w firmie. Jest Prezes, który ma pod sobą Dyrektora Finansów i Dyrektor Logistyki
 * W finansach pracuje księgowa, a w logistyce spedytor, magazynier i kierowca. 
 * Stwórz program na bazie kompozytu.
 * (proponuję ustawić kole stanowisko i definiować je jednak w konstruktorze dla wygody)
 */
