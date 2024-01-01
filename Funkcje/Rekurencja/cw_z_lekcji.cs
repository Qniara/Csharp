//Zad.1
//Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
//string n = Console.ReadLine();
//int suma = 0;
//foreach(var i in n)
//{
//    suma += (char)i;
//}
//Console.Write(suma);

//int zad1(string n)
//{
//    if (n == "") return 0;
//    return (int)n[0] + zad1(n.Substring(1));
//}
//Console.WriteLine(zad1("A"));

//Zad.2
//Napisz iteracyjnie i rekurencyjnie obliczenie x^n (x do potęgi n)
//Console.Write("Podaj liczbe: ");
//int x = int.Parse(Console.ReadLine());
//int x2 = x;
//Console.Write("Podaj liczbe: ");
//int n = int.Parse(Console.ReadLine());
//for(int i=1; i<n; i++)
//{
//    x = x * x2;
//}
//Console.WriteLine(x);

//int zad2(int x, int n)
//{
//    if (n > 0)
//    {
//        return x * zad2(x, n - 1);
//    }
//    else
//    {
//        return 1;
//    }
//}
//Console.WriteLine(zad2(2, 3));

//Zad.3
//Napisz algorytmy NWD modulo i odejmowanie w wersji reku
//int zad3a(int a, int b)
//{
//    if (a > b)
//    {
//        return zad3a(a - b, a);
//    }
//    else if (a < b)
//    {
//        return zad3a(a, b - a);
//    }
//    else
//    {
//        return a;
//    }
//}
//Console.WriteLine(zad3a(25, 10));

//int zad3b(int a, int b)
//{
//    if (b > 0)
//    {
//        return zad3b(b, a % b);
//    }
//    else
//    {
//        return a;
//    }
//}
//Console.WriteLine(zad3b(20, 10));
