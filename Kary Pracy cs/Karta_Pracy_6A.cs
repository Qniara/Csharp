//Zad.1 - do sprawdzenia jeszcze
//int suma = 0;
//int n = int.Parse(Console.ReadLine());
//int x = n;
//for (int i = 0; x <= 1; i++)
//{
//    x = n % 10;
//    suma = suma + x;
//}
////int i = 0;
////while (x == 0)
////{
////    i++;
////    x = n % 10;
////    suma = suma + x;
////}
//Console.WriteLine(suma);
//Zad.2
//int n = int.Parse(Console.ReadLine());
//int flaga = 1;
//for(int i = 2; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        flaga = 0;
//    }
//}
//if (flaga == 1)
//    {
//        Console.WriteLine("Podana liczba jest pierwsza.");
//    }
//else
//{
//        Console.WriteLine("Podana liczba nie jest pierwsza.");
//}
//Zad.3
//int suma = 0;
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        suma = suma + i;
//    }
//}
//if (n == suma)
//{
//    Console.WriteLine("Podana liczba jest doskonala");
//}
//else
//{
//    Console.WriteLine("Podana liczba nie jest doskonała");
//}
//Zad.4
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//while (a != b)
//{
//    if (a > b)
//    {
//        a = a - b;
//    }
//    else
//    {
//        b = b - a;
//    }
//}
//if (a == 1)
//{
//    Console.WriteLine("Podane liczby sa wzglednie pierwsze");
//}
//else
//{
//    Console.WriteLine("Podane liczby nie sa wzglednie pierwsze");
//}
//Zad.5
//int m = int.Parse(Console.ReadLine());
//int x = 0;
//int y = 0;
//for (int i= 10; i < 20; i++)
//{
//    x = m;
//    y = i;
//    while (x != y)
//    {
//        if (x > y)
//        {
//            x = x - y;
//        }
//        else
//        {
//            y = y - x;
//        }
//    }
//    if (x == 1)
//    {
//        Console.WriteLine(i + " ");
//    }
//}
//Zad.6
//int a= int.Parse(Console.ReadLine());
//int b= int.Parse(Console.ReadLine());
//int x = a;
//int y = b;
//while (x != y)
//{
//    if (x > y)
//    {
//        x = x - y;
//    }
//    else
//    {
//        y = y - x;
//    }
//}
//a = a / x;
//b = b / x;
//Console.WriteLine(a + "/" + b);
//Zad.7
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = a / b;
//a = a - c * b;
//int x = a;
//int y = b;
//while(x != y)
//{
//    if (x > y)
//    {
//        x = x - y;
//    }
//    else
//    {
//        y = y - x;
//    }
//}
//a = a / x;
//b = b / x;
//Console.WriteLine(c+" "+a+"/"+b);
