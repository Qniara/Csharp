//REKURENCJA
//for(int i = 1; i <= 5; i++)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
//void re1(int n)
//{
//    Console.Write(n + " ");
//    if (n == 5) return;
//    else re1(n + 1);
//}
//re1(1);

//void re2(int n)
//{
//    if (n == 0) return;
//    Console.Write(n + " ");
//    re2(n - 1);
//    Console.Write(n + " ");
//}
//re2(5);

// 3.Napisz algorytm sumujacy cyfry iter i reku
//int suma = 0;
//for (int i = 0; i < 10; i++)
//{
//    suma = suma + i;
//}
//Console.WriteLine(suma + "\n");
//suma = 0;
//void Suma(int n)
//{
//    if (n == 10)
//    {
//        Console.WriteLine(suma);
//        return;
//    }
//    suma = suma + n;
//    Suma(n + 1);
//}
//Suma(0);

// 4.Napisz alg sumujący liczby dwucyfrowe parzyste iter i reku
//int suma = 0;
//for (int i = 10; i < 100; i += 2)
//{
//    suma = suma + i;
//}
//Console.WriteLine(suma);
//reku
//int suma = 0;
//void Sum(int n)
//{
//    if (n == 100)
//    {
//        Console.WriteLine(suma);
//        return;
//    }
//    suma = suma + n;
//    Sum(n + 2);
//}
//Sum(10);

// 5. Oblicz sumę n pierwszych wyrazów ciągów:
// a) 3, 6, 9, 12, 15, 18, 21 ... <=> 3+6+9+12 = 3(1+2+3+4)
//Sposob 1
//int n = 4;
//int r5a1(int n)
//{
//    if (n == 1) return 3;
//    return r5a1(n - 1) + 3 * n;
//}
//Console.WriteLine(r5a1(3));

//Sposob 2
//int r5a2(int n)
//{
//    if (n == 1) return 3;
//    return r5a2(n - 1) + 3;
//}
//int s5a2 = 0;
//for(int i = 1; i <= 4; i++)
//{
//    s5a2 = r5a2(i);
//}
//Console.WriteLine(r5a2(s5a2));

// b) 12, 23, 34, 45, 54 ...
//int n = 4;
//int r5b(int n)
//{
//    if (n == 1) return 12;
//    return r5b(n - 1) + 11;
//}
//int s5b = 0;
//for(int i = 1; i <= n; i++)
//{
//    s5b = r5b(i);
//}
//Console.WriteLine(r5b(s5b));

// c) 2, 6, 18, 54 ...


// d) 1, 4, 9, 16 ...
//To nie działa ale kiedyś bedzie
//int n = 4;
//int r5d(int n)
//{
//    if (n == 1) return 1;
//    return r5d((n + 1) * (n + 1));
//}
//int s5d = 0;
//for(int i = 1; i <= n; i++)
//{
//    s5d=r5d(i);
//}
//Console.WriteLine(r5d(s5d));

//To działa
//int n = 4;
//int r5d(int n)
//{
//    if (n == 1) return 1;
//    return r5d(n - 1) + 2 * (n - 1) + 1;
//}
//int s5d = 0;
//for (int i = 1; i <= n; i++)
//{
//    s5d = r5d(i);
//}
//Console.WriteLine(r5d(s5d));

// 6. Wypisz n pierwszych wyrazów ciągu:
// a) 1,5  1  0,5  -0,5  -2  -4,5  -8,5  -15


// b) -2  2,5  3  -5  7,5  -4,5  -0,5  8  -12,5


// c) 0  1  -1  2  -2  3  -3  4  -4


// 7. Inne ciągi kosmiczne - rakieta USA

// 1  3  4   8  15   27

// 4    5    -3    2   14   22    48   

// 1    1    1    3   5   9   

// 2   3    4     -1    -8    -11   -2  

// 1   4    3    16     5     64     7    256   9   1024
