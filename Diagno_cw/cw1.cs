// Przed Diagnozą

//Alorytmy

//Napisz i przetestuje algorytm Eklidesa odejmowanie, modulo i sort bombelkowe
//bez funkcji
//odejmowanie
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//while (a > b)
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
//Console.WriteLine(a);
//z funkcją
//void nwd(int a, int b)
//{
//    while (a > b)
//    {
//        if (a > b)
//        {
//            a = a - b;
//        }
//        else
//        {
//            b = b - a;
//        }
//    }
//    Console.WriteLine(a);
//}
//nwd(a, b);

//modulo
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int pom;
//while (b > 0)
//{
//    pom = b;
//    b = a % b;
//    a = pom;
//}
//Console.WriteLine(a);

//Bombelkowe
//void sort(int[] T)
//{
//    int pom;
//    int n = T.Length;
//    for(int i= n-1; i>=0; i--)
//    {
//        for(int j = 0; j < i; j++)
//        {
//            if (T[j] > T[j + 1])
//            {
//                pom = T[j+1];
//                T[j + 1] = T[j];
//                T[j] = pom;
//            }
//        }
//    }
//}
//int[] T = new int[20];
//Random r=new Random();
//for(int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(1,100);
//}
//for(int i = 0; i < 20; i++)
//{
//    Console.Write(T[i] + " ");
//}
//Console.WriteLine();
//sort(T);
//for (int i = 0; i < 20; i++)
//{
//    Console.Write(T[i] + " ");
//}

//Wypisz wszystkie pary licz zaprzyjaźnionych z przedziału od 1 do 10000
//int sumcia(int x)
//{
//    int suma=0;
//    for (int i = 1; i < x; i++)
//    {
//        if (x % i == 0)
//        {
//            suma = suma + i;
//        }
//    }
//    return suma;
//}
//for (int i = 1; i <= 10000; i++)
//{
//    for(int j = 1; j <= 10000; j++)
//    {
//        int x = sumcia(j);
//        int y = sumcia(i);
//        if (i != j && y==j && x==i)
//        {
//            Console.WriteLine(i + " " + j);
//        }
//    }
//}

//W tablicy 30 losowych liczb 3 cyfrowych znjadź ilość wielokrotności liczby 17(zapisz te liczby do listy wynikowej)
//using System.Collections;
//int[] T = new int[30];
//Random r = new Random();
//ArrayList L = new ArrayList();
//for(int i =0;i<30; i++)
//{
//    T[i] = r.Next(100,1000);
//    Console.Write(T[i] + " ");
//    if (T[i] % 17 == 0)
//    {
//        L.Add(T[i]);
//    }
//}
//foreach(int i in L)
//{
//    Console.Write(i + " ");
//}

//Wypisz sumy kolejnych ramek macierzy kwadrotowej o n parzystym
//using System.Collections;
//int[,] T = new int[8,8];
//Random r= new Random();
//for(int i=0;i<8; i++)
//{
//    for(int j=0;j<8; j++)
//    {
//        T[i, j] = r.Next(1, 10);
//    }
//}
//for(int i=0; i<8; i++)
//{
//    for(int j=0;j <8; j++)
//    {
//        Console.Write(T[i, j]+"   ");
//    }
//    Console.WriteLine("");
//}
//List<int> S = new List<int>;
//int suma = 0;
//int n = 8;
//for (int i = 0; i < n / 2; i++)
//{
//    for (int j = 0; j < n - 2 - i; j++)
//    {
//        for (int k = n / 2 - i; k < n / 2 + i; k++)
//        {
//            suma = suma + T[j, k];
//        }
//    }
//    S.Add(suma);
//}
//Console.WriteLine();
//foreach (var s in S)
//{
//    Console.WriteLine(s);
//}
//int[] L = S.ToArray();

//for(int i = 0; i < S.Count; i++)
//{
//    Console.WriteLine(S[i]);
//}
