//Zad.1
//Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
//Iteracja
//Console.WriteLine("Napisz cos: ");
//string n = Console.ReadLine();
//List<int> list = new List<int>();
//int suma = 0;
//for(int i = 0; i < n.Length; i++)
//{
//    list[i] = (char)n[i];
//    suma = suma + list[i];
//}
//Console.WriteLine(suma);

//Reku
//int funkcja(string n)
//{
//    if (n == "")
//    {
//        return 0;
//    }
//    return funkcja(n.Substring(1))+(int)n[0];

//}
//Console.WriteLine(funkcja("A"));

//Zad.2
//Napisz iteracyjnie i rekurencyjnie obliczenie x^n (x do potęgi n)
//Iteracja
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = 1;
//for(int i= 0; i < b; i++)
//{
//    c = c * a;
//}
//Console.WriteLine(c);

//Reku
//int funkcja(int x, int n)
//{
//    if (n == 0)
//    {
//        return 1;
//    }
//    return funkcja(x, n - 1) * x;
//}
//Console.WriteLine("Podaj liczbe: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj liczbe: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine(funkcja(a, b));

//Zad.3
//Napisz algorytmy NWD modulo i odejmowanie w wersji reku
//Iteracja
//int a=int.Parse(Console.ReadLine());
//int b=int.Parse(Console.ReadLine());
//while (a != b)
//{
//    if (a > b)
//    {
//        a = a - b;
//    }
//    else
//    {
//        b=b - a;
//    }
//}
//Console.WriteLine(a);

//Reku
//int funkcja(int a, int b)
//{
//    if (a > b)
//    {
//        return funkcja(a - b, b);
//    }
//    if (b > a)
//    {
//        return funkcja(a, b - a);
//    }
//    else
//    {
//        return a;
//    }
//}
//Console.WriteLine(funkcja(40,20));
