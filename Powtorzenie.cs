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
