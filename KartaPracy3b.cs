using System;
{
    // Zad.1
    //for (int i = 1; i < 31; i++)
    //{
    //    Console.WriteLine(i);
    //}
    //Zad.2
    //for (int i = 1; i < 10; i=i+2)
    //{
    //    Console.WriteLine(i^2);
    //}
    //Zad.3
    //for (int i = 1000; i<10000; i++)
    //{
    //    if (i % 379 == 0)
    //    {
    //        Console.Write(i);
    //    }
    //}
    //Zad.4
    //for (int i = 100; i < 1000; i++)
    //{
    //    if (i%5==0 && i%6==0 || i % 11 == 0)
    //    {
    //        Console.Write(i);
    //    }
    //}
    //Zad.5
    //int n = int.Parse(Console.ReadLine());
    //int suma = 0;
    //for (int i = 0; i <= n; i++)
    //{
    //    int a = int.Parse(Console.ReadLine());
    //    suma = suma + a;
    //    Console.WriteLine(suma);
    //}
    //Zad.6
    //int k = int.Parse(Console.ReadLine());
    //int suma = 0;
    //for (int i = 0; i <= k; i++)
    //{
    //    suma = suma + i;
    //    Console.WriteLine(suma);
    //}
    //Zad.7
    //int m = int.Parse(Console.ReadLine());
    //int suma = 0;
    //for (int i = 11; i < 100; i = i + 2)
    //{
    //    suma = suma + i;
    //    Console.WriteLine(suma);
    //}
    //Zad.8
    int w0 = int.Parse(Console.ReadLine());
    int l = int.Parse(Console.ReadLine());
    int w = w0;
    for (int i = w0; i <= l; i++)
    {
        w = w * 0.6 + w;
    }
}