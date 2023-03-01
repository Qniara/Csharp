//Zad.1
//using System.Collections;
//ArrayList A = new ArrayList();
//int n = int.Parse(Console.ReadLine());
//for(int i = 1; i <= n; i++)
//{
//    if (n % i == 0)
//    {
//        A.Add(i);
//    }
//}
//foreach(var item in A)
//{
//    Console.Write(item + " ");
//}

//Zad.2
//int[] T=new int[20];
//int x=0;
//int n = 0;
//Random r=new Random();
//while (x < 20)
//{
//    n = r.Next(100, 1000);
//    if (n % 50 == 0)
//    {
//        T[x] = n;
//        x += 1;
//    }
//}
//for (int j = 0; j < T.Length; j++)
//{
//    Console.Write(T[j] + " ");
//}

//Zad.3
//int n=int.Parse(Console.ReadLine());
//int sum1 = 0;
//int sum2 = 0;
//int[] T = new int[n];
//Random r = new Random();
//if (n % 2 == 1)
//{
//    Console.WriteLine("Podana liczba nie jest parzysta.");
//}
//else
//{
//    for(int i = 0; i < n / 2; i++)
//    {
//        T[i] = r.Next(10, 100);
//        sum1=sum1+T[i];
//        Console.Write(T[i] + " ");
//    }
//    Console.WriteLine();
//    for (int j = n/2; j < T.Length; j++)
//    {
//        T[j] = r.Next(10, 100);
//        sum1 = sum1 + T[j];
//        Console.Write(T[j] + " ");
//    }
//    Console.WriteLine();
//    if(sum1 > sum2)
//    {
//        Console.WriteLine("Czesc pierwsza podanej tablicy ma większa sume");
//    }
//    else if(sum2>sum1)
//    {
//        Console.WriteLine("Czesc druga podanej tablicy ma większa sume");
//    }
//}

//Zad.4
//int[,] T = new int[25,25];
//Random r = new Random();
//int suma = 0;
//int ilo = 0;
//for (int i = 0; i < T.Length; i++)
//{
//    for (int j = 0; j < T.Length; j++)
//    {
//        T[i, j] = r.Next(100, 1000);
//        Console.Write(T[i, j] + " ");
//    }
//}
//Console.WriteLine();
//for (int a = 0; a < T.Length; a++)
//{
//    for (int b = 0; b < T.Length; b++)
//    {
//        for(int c = 1; c < T.Length; c++)
//        {
//            for (int d = 1; d < T.Length; d++)
//            {
//                if (T[a, b] == T[c, d])
//                {
//                    ilo++;
//                }
//            }
//        }
//        if (ilo > 1)
//        {
//            Console.Write(T[a, b] + " ");
//        }
//    }
//}
