//Zad.1
//int n = int.Parse(Console.ReadLine());
//int f (int x)
//{
//    if (x % 3 == 0)
//    {
//        Console.WriteLine("TAK");
//    }
//    else
//    {
//        Console.WriteLine("NIE");
//    }
//    return 0;
//}
//Console.WriteLine(f(n));

//Zad.2
//int n = int.Parse(Console.ReadLine());
//int f(int x)
//{
//    if (x % 17 == 0 && 99<x && x<1000)
//    {
//        Console.WriteLine("TAK");
//    }
//    else
//    {
//        Console.WriteLine("NIE");
//    }
//    return 0;
//}
//Console.WriteLine(f(n));

//Zad.3
//int n = int.Parse(Console.ReadLine());
//int f(int x)
//{
//    if (x > 17)
//    {
//        Console.WriteLine("TAK");
//    }
//    else
//    {
//        Console.WriteLine("NIE");
//    }
//    return 0;
//}
//Console.WriteLine(f(n));

//Zad.4
//int n = int.Parse(Console.ReadLine());
//int limit = 20;
//int f(int x)
//{
//    if (x <= limit)
//    {
//        Console.WriteLine("TAK");
//    }
//    else
//    {
//        Console.WriteLine("NIE");
//    }
//    return 0;
//}
//Console.WriteLine(f(n));

//Zad.5
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int f(int x, int y, int z)
//{
//    if (x<z && x>y)
//    {
//        Console.WriteLine("TAK");
//    }
//    else if (y > z && x > y)
//    {
//        Console.WriteLine("TAK");
//    }
//    else if (x < z && z < y)
//    {
//        Console.WriteLine("TAK");
//    }
//    else if (x > z && z < y && y > x)
//    {
//        Console.WriteLine("TAK");
//    }
//    else
//    {
//        Console.WriteLine("NIE");
//    }
//    return 0;
//}
//Console.WriteLine(f(a, b, c));

//Zad.6
//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());
//double f (double x, double y)
//{
//    bool g = true;
//    for(double i = 2; i < y; i++)
//    {
//        if (y % i == 0)
//        {
//            g = false;
//        }
//    }
//    if (g == false)
//    {
//        Console.WriteLine("NIE");
//    }
//    else
//    {
//        if (Math.Pow(x, y) % y == 0)
//        {
//            Console.WriteLine("TAK");
//        }
//        else
//        {
//            Console.WriteLine("NIE");
//        }
//    }
//    return 0;
//}
//Console.WriteLine(f(a, b));

//Zad.7
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int f (int s,int p, int k)
//{
//    if (k - p <= 3 * s)
//    {
//        Console.WriteLine("TAK");
//    }
//    else
//    {
//        Console.WriteLine("NIE");
//    }
//    return 0;
//}
//Console.WriteLine(f(a, b, c));
