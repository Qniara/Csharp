//Zad.1
//Wygeneruj tablice 15 losowych liczb dwucyfrowych nieparzystych
//int[] T = new int[15];
//int x = 1;
//Random r = new Random();
//while (x < 15)
//{
//    for (int i = 0; i < x; i++)
//    {
//        T[i] = r.Next(10, 100);
//        if (T[i] % 2 == 1)
//        {
//            Console.WriteLine(x + ". " + T[i] + " ");
//            x = x + 1;
//        }
//    }
//}

//Zad.2
//Wygeneruj tablice 20 dowolnych liczb 2cyfrowych i zaokrąglij każdą w góre do pełnej 10;
//int[] T = new int[20];
//int x = 0;
//int n = 0;
//Random r = new Random();
//for (int i = 1; i < 21; i++)
//{
//    T[i] = r.Next(10, 100);
//    x = 10 - (T[i] % 10);
//    n = T[i] + x;
//    Console.WriteLine(T[i]+" "+n);
//}

//Nie działa XD
//int[] T = new int[20];
//Random r = new Random();
//for (int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(10, 100);
//    Console.WriteLine(T[i] + " ");
//    if(T[i] % 10 != 0)
//    {
//        T[i] = (T[i] / 10) * 10;
//    }
//    Console.WriteLine(T[i]);
//}

//Zad.3
//Wygeneruj liste 12 losowych liczb dwucyfrowych podzielnych przez 7
//int[] T = new int[12];
//int x = 1;
//Random r = new Random();
//while (x < 12)
//{
//    for (int i = 1; i < 13; i++)
//    {
//        T[i] = r.Next(10, 100);
//        if (T[i] % 7 == 0)
//        {
//            Console.WriteLine(x + ". " + T[i]);
//            x = x + 1;
//        }
//    }
//}

// Przykladowy sprawdzian
//using System.Collections;

//Zad.1
//ArrayList A = new ArrayList();
//int n=int.Parse(Console.ReadLine());
//for(int i=1; i<=n; i++)
//{
//    if (n % i == 0)
//    {
//        A.Add(i);
//    }
//}
//foreach (var item in A)
//{
//    Console.WriteLine(item + " ");
//} 

//Zad.2
//bool czypie(int n)
//{
//    for(int i = 0; i < n; i++)
//    {
//        if (n % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}
//int[] T = new int[20];
//Random r = new Random();
//int n = 0;
//int x = 0;
//while (n < 20)
//{
//    x = r.Next(100, 1000);
//    if(czypie(x)==false && x%2==1 && x % 3 != 0)
//    {
//        T[n] = x;
//        n++;
//    }
//}

//Zad.3
//Random r = new Random();
//int[] T = new int[40];
//int suma = 0;
//int x = 0;
//for(int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(10, 100);
//    for (int j=0; j<T.Length; j++)
//    {
//        if (T[i] == T[j])
//        {
//            x = x + 1;
//        }
//    }
//    if (x > 1)
//    {
//        suma = suma + T[i];
//    }
//}
//Console.WriteLine(suma);
