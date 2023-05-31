//Zad.1
//Random r = new Random();
//int[] T = new int[50];
//int ilo = 0;
//int ilo2 = 0;
//for(int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(-100,100);
//}
//for(int i=0;i<T.Length; i++)
//{
//    if (T[i] % 2 == 0)
//    {
//        Console.Write(T[i] + " ");
//    }
//    if (T[i] > 0)
//    {
//        ilo = ilo + T[i];
//    }
//    else if (T[i] < 0)
//    {
//        ilo2 = ilo2 + T[i];
//    }
//}
//Console.WriteLine();
//for (int i = 0; i < T.Length; i++)
//{
//    if (T[i] % 2 != 0)
//    {
//        Console.Write(T[i] + " ");
//    }
//}
//Console.WriteLine();
//if (ilo2 > 0)
//{
//    ilo = ilo / ilo2;
//    Console.WriteLine(ilo);
//}

//Zad.2
//using System.Collections;
//int x = 0;
//int maks = 0;
//ArrayList A = new ArrayList();
//while (x >= 0)
//{
//    int n=int.Parse(Console.ReadLine());
//    A.Add(n);
//    if (maks < n)
//    {
//        maks = n;
//    }
//}
//Random r = new Random();
//int[] T = new int[maks];
//for(int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(-199, 199);
//}
//ArrayList B = new ArrayList();
//for(int i = 0; i < T.Length; i++)
//{
//    if (T[i] % 2 == 0)
//    {
//        B.Add(T[i]);
//    }
//}
//int q = 0;
//int suma = 0;
//for(int i = 0; i < B.Count; i=i+2)
//{
//    suma = suma + T[i];
//    q = q + 1;
//}
//suma = suma / q;
//int suma2 = 0;
//int w = 0;
//for(int i = 0; i < T.Length; i = i + 3)
//{
//    suma2=suma2 + T[i];
//    w = w + 1;
//}
//suma2 = suma2 / w;
//int srart = suma / suma2;
//Console.WriteLine(suma + " " + suma2 + " " + srart);
