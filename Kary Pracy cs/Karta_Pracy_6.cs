//Zad.1
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int x = c - b;
//int y = b - a;
//int k = a - b;
//int l = b - c;
//int n = c / b;
//int m = b / a;
//int e = a / b;
//int d = b / c;
//if (x == y || k == l)
//{
//    Console.WriteLine("Podany ciag jest arytmetyczny.");
//}
//else
//{
//    Console.WriteLine("Podany ciag nie jest arytmetyczny");
//}
//if(n==m || e == d)
//{
//    Console.WriteLine("Podany ciag jest geometryczny");
//}
//else
//{
//    Console.WriteLine("Podany ciag nie jest geometryczny");
//}
//if (a > c)
//{
//    Console.WriteLine("Podany ciag jest malejacy");
//}
//else if (a < c)
//{
//    Console.WriteLine("Podany ciag jest rosnacy");
//}
//Zad.2
//int suma = 0;
//for(int i = 100; i < 1000; i++)
//{
//    if(i%8==0 && i % 16 != 0)
//    {
//        suma = suma + i;
//    }
//}
//Console.WriteLine(suma);
//Zad.3
//int x = 0;
//int ilo = 0;
//for(int i = 10; i < 100; i++)
//{
//    if (i % 7 == 0)
//    {
//        x = i;
//    }
//}
//for(int j = 1000; j < 10000; j++)
//{
//    if (j % x == 0)
//    {
//        ilo = ilo + 1;
//    }
//}
//Console.WriteLine(ilo);
//Zad.4
//int ilo = 0;
//int x = 0;
//int y = 0;
//for(int i = 10; i < 100; i++)
//{
//    x = i % 10;
//    y = i % 100 - x;
//    if(y >= x*2)
//    {
//        ilo = ilo + 1;
//    }
//}
//Console.WriteLine(ilo);
//Zad.5
//int suma = 0;
//int ilo = 0;
//int x = 0;
//int y = 0;
//int z = 0;
//for(int i = 100; i < 1000; i++)
//{
//    x = i % 10;
//    y = i % 100 - x;
//    z = i % 1000 - y - x;
//    if (z > y + x)
//    {
//        suma = suma + i;
//        ilo = ilo + 1;
//    }
//}
//Console.WriteLine(suma+" i "+ilo);
//Zad.6
//int n=int.Parse(Console.ReadLine());
//int suma = 0;
//for(int i = 19; i < 19 + 19 * n; i++)
//{
//    if (i % 19 == 0)
//    {
//        suma = suma + i;
//    }
//}
//Console.WriteLine(suma);
//Zad.7
//int n=int.Parse(Console.ReadLine());
//int suma = 0;
//for(int i = 999; i > 999 - 37 * n; i--)
//{
//    if (i % 37 == 0)
//    {
//        suma = suma + i;
//    }
//}
//Console.WriteLine(suma);
//Zad.8
//int n=int.Parse(Console.ReadLine());
//int suma = 0;
//for(int i = -1; i < n * 3; i = i + 3)
//{
//    if(i%2 == 0)
//    {
//        suma = suma + i;
//    }
//    else if(i%2 == 1)
//    {
//        suma = suma - i;
//    }
//}
//Console.WriteLine(suma);
//Zad.9
//double ilo = 1;
//double x = 0;
//int n=int.Parse(Console.ReadLine());
//for(double i = 0; i < n; i++)
//{
//    x = Math.Pow(2, i);
//    if (i % 2 == 1)
//    {
//        ilo = ilo * (-1 * x);
//    }
//    else if(i % 2 == 0)
//    {
//        ilo = ilo * x;
//    }
//}
//Console.WriteLine(ilo);
//Zad.10
//int suma = 0;
//int ilo = 1;
//int n=int.Parse(Console.ReadLine());
//for(int i = 1; i <= n; i++)
//{
//    for(int j = 1; j < i; j++)
//    {
//        ilo = ilo * j;
//    }
//    suma = suma + ilo;
//}
//Console.WriteLine(suma);
//Zad.11
//int n=int.Parse(Console.ReadLine());
//float l = 0;
//float m = 0;
//int x = 0;
//float suma = 0;
//for(int i = 1; i <= n; i=i+2)
//{
//    x = x + i;
//    l = l + i;
//    m = m + x;
//}
//suma = suma + (l / m);
//Console.WriteLine(suma);
//Zad.12
//int l = 0;
//int m = 0;
//int x = 0;
//int n=int.Parse(Console.ReadLine());
//for(int i = 1; i <= n; i = i + 2)
//{
//    x = x + i;
//    m = m + x;
//    l = l + i;
//}
//Console.WriteLine(l+"/"+m);
//Zad.15 -> logicznie rzecz bioronc działa
//int n = int.Parse(Console.ReadLine());
//double m = 1;
//int l = 3;
//for(double i = 0; i < n; i++)
//{
//    m = m * m + (Math.Pow(2, i));
//    l = l * l + 1;
//}
//Console.WriteLine(l+"/"+m);
//Zad.16  -> Chyba działa (chyba)
//int n = int.Parse(Console.ReadLine());
//int a = 0;
//int b = 1;
//int temp = 0;
//int licznik = 1;
//double mianownik = 1;
//for(double i=0; i < n; i++)
//{
//    i = Math.Pow(2,i);
//    temp = a + b;
//    a = b;
//    b = temp;
//    mianownik = mianownik * i;
//    licznik = licznik * temp;
//}
//Console.WriteLine(licznik+"/"+mianownik);
