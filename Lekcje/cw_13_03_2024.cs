/*KLASY i FASADY
 * Kompozycja - scisle połączenie 
 *  - np. Kombajn i gitara
 *  - podlaczenie obiektu w konstruktorze
 * Agregacja - porządane połączenie 
 *  - np. Kombajn i zapasowa gitara
 *  - podlaczenie w set
 * Asocjacja - dowolnie, nie niezbędne połączenie
 *  - np. Kombajn i wszystkie struny w gitarze
 */

---------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw_13_03_2024_2
{
    class Przyklad
    {
        /* POLA
         * private, public, protected, international*/
        private int wiek;
        public string imie;
        private int wzrost;
         /* WŁAŚCIWOŚCI
         * public int wzrost { get; set;}
         * METODY*/
         public int Wzrtost
        {
            get
            {
                return wzrost + 100;
            }
            set
            {
                if (value > 100)
                {
                    wzrost = 500;
                }
                else
                {
                    wzrost = value;
                }
            }
        }
        public void setWiek(int awiek)
        {
            this.wiek = awiek;
            //wiek=awiek tez zadziala

        }
    }
    class KoloZapas { }
    class Auto
    {
        KoloZapas kolo;
        public void setKolo(KoloZapas kolo)
        {
            this.kolo = kolo;
        }
    }
    class Nauczyciel { }
    class Szkola
    {
        Nauczyciel nau;
        void NauDoPracy(Nauczyciel n)
        {
            nau = n;
        }
    }
    class Klient { }
    class Produkt { }
    class Dostawa { }
    class Zamowienia
    {
        Klient k;
        Produkt p;
        Dostawa d;
        public void setKlient(Klient K)
        {
            this.k = K;
        }
        public void setProdukt(Produkt P)
        {
            this.p = P;
        }
        public void setDostawa(Dostawa D)
        {
            this.d = D;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
