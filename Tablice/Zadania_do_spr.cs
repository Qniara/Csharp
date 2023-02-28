//Zad.1
//using System.Collections;
//ArrayList A=new ArrayList();
//int n=int.Parse(Console.ReadLine());
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
//bool f = false;
//int x = 0;
//bool F(int x)
//{
//    for(int i = 2; i < x; i++)
//    {
//        if (x % i == 0)
//        {
//            f=true;
//        }
//    }
//    if (f == true)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Random r= new Random();
//int[] T = new int[20];
//for(int i = 0; i < T.Length; i++)
//{
//    x = r.Next(100,1000);
//    if(F(x)==false && x%2==1 && x % 3 != 0 && x % 5 != 0 && x % 7 != 0)
//    {
//        T[i] = x;
//    }
//}
//foreach(int j in T)
//{
//    Console.Write(T[j] + " ");
//}

//Zad.3
//Random r= new Random();
//int[] T = new int[40];
//int suma = 0;
//int ilo = 0;
//for(int i = 0; i < T.Length; i++)
//{
//    for(int j = 1; j <= T.Length; j++)
//    {
//        if (T[i] == T[j])
//        {
//            ilo += 1;
//        }
//    }
//    if (ilo == 1)
//    {
//        suma += T[i];
//    }
//}
//Console.WriteLine(suma);
