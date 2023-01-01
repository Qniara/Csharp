using System;
{
    //Zad.1
    int a = int.Parse(Control.Readline());
    int b = int.Parse(Control.Readline());
    if ((a + b) % 2 == 0)
    {
        Console.Writeline("Suma jest parzysta");
    }
    else
    {
        Console.Writeline("Suma nie jest parzysta");
    }
    //Zad.2
    import Math;
    int a = int.Parse(Control.Readline());
    int b = int.Parse(Control.Readline());
    int art = (a + b) / 2;
    int g = Math.sqrt(a * b);
    if (art > g) ;
    {
        Console.Writeline("TAK");
    }
    else
    {
        Console.Wrieline("NIE");
    }
    //Zad.3
    int k = int.Parse(Control.Readline());
    int l = int.Parse(Control.Readline());
    int m = int.Parse(Control.Readline());
    if (k == l)
    {
        Console.Writeline("Tak, " + k, l);
    }
    else if (k == m)
    {
        Console.Writeline("Tak, " + k, m);
    }
    else if (l == m)
    {
        Console.Writeline("Tak, " + k, m);
    }
    else
    {
        Conosle.Writeline("Nie ma rownych liczb");
    }
    //Zad.4
    int a = int.Parse(Control.Readline());
    int b = int.Parse(Control.Readline());
    int c = int.Parse(Control.Readline());
    int d = int.Parse(Control.Readline());
    if (a<b && a&&c && a<d)
    {
        Console.Writeline(a);
    }
    else if (b<a && b<c && b<d)
    {
        Console.Writeline(b);
    }
    else if (c<a && c<b && c<d)
    {
        Console.Writeline(c);
    }
    else
    {
        Console.Writeline(d);
    }
    //Zad.5
    int a = int.Parse(Control.Readline());
    int b = int.Parse(Control.Readline());
    int c = int.Parse(Control.Readline());
    if (a < b + c && b < a + c && c < b + a)
    {
        Conosle.Writeline("Liczby spelniaja nierownosc trojkata");
    }
    else
    {
        Console.Writeline("Liczby nie spelniaja nierownosci trojkata");
    }
    //Zad.6
    int a = int.Parse(Control.Readline());
    int b = int.Parse(Control.Readline());
    int c = int.Parse(Control.Readline());
    if (c * *2 = a * *2 + b * *2)
    {
        Console.Writeline("Trojkat bedzie prostokatny");
    }
    else if (c * *2 < a * *2 + b * *2)
    {
        Console.Writeline("Trojkat bedzie ostrokatny");
    }
    else if (c * *2 > a * *2 + b * *2)
    {
        Console.Writeline("Trojkat bedzie rozwartokatny");
    }
}