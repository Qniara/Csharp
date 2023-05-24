//Zad.1
//int x = int.Parse(Console.ReadLine());
//void f(int n)
//{
//    int x = 0;
//    int suma = 0;
//    while (n > 0)
//    {
//        if (n % 16 == 0)
//        {
//            n = n / 16;
//        }
//    }
//    while (n > 0)
//    {
//        suma = suma + n % 10;
//        n = n / 10;
//    }
//}
//f(x);

//Zad.2
//void f2(int n)
//{
//    int[] T = new int[n];
//    T[0] = 1;
//    T[1] = 2;
//    T[2] = 3;
//    for (int i = 0; i < n; i++)
//    {
//        if (i <= 3)
//        {
//            Console.Write(T[i] + " ");
//        }
//        else if (i == 4)
//        {
//            int a = T[0] + T[2] + T[3];
//            Console.Write(T[0] + T[1] + " ");
//            T.Append(a);
//        }
//        else if (i % 2 == 0)
//        {
//            T[i] = T[i - 1] - T[i - 4];
//        }
//        else
//        {
//            T[i] = T[i - 1] + T[i - 2] + T[i - 3];
//            Console.Write(T[i] + " ");
//        }
//    }
//}
//int x = int.Parse(Console.ReadLine());
//f2(x);

//Zad.3
//using System.IO;
//Random r= new Random();
//int[,] T = new int[30, 3];
//for (int i = 0; i < 30; i++)
//{
//    for(int j = 0; j < 3; j++)
//    {
//        T[i, j] = r.Next(1, 20);
//        //Console.Write(T[i, j] + " ");
//        //if (j == 2) Console.WriteLine();
//    }
//}
//var files = Directory.GetFiles("C://Users//uczen//Documents//", "document.txt", SearchOption.TopDirectoryOnly);
//foreach (string file in files)
//{
//    File.WriteAllText(file, T[]);
//}










//1 z kartki tej drugiej
//int[] T = new int[50];
//int i = 0;
//void f3(int n)
//{
//    while (n > 0)
//    {
//        T[i] = n % 10;
//        n = n / 10;
//        i++;
//    }
//    int min = 20;
//    for (int i = 0; i < T.Length; i++) 
//    {
//        if (T[i] < min)
//        {
//            min = T[i];
//        }
//    }
//    Console.WriteLine(min);
//}
//int x = int.Parse(Console.ReadLine());
//f3(x);
