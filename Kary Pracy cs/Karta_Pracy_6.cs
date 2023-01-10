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
