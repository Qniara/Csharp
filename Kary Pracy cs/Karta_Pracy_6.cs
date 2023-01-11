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
