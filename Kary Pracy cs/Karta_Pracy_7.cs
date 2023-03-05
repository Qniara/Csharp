int[] T = new int[40];
Random r = new Random();
for (int t = 0; t < 40; t++)
{
    T[t] = r.Next(10,100);
    Console.Write(T[t] + " ");
}
//Zad.1
//int maks = 0;
//for (int i = 0; i < T.Length; i++)
//{
//    if (maks < T[i])
//    {
//        maks = T[i];
//    }
//}
//Console.WriteLine(maks);

//Zad.2
//int mini = 101;
//for (int i = 0; i < T.Length; i++)
//{
//    if (mini > T[i])
//    {
//        mini = T[i];
//    }
//}
//Console.WriteLine(mini);

//Zad.3
//int mini = 101;
//int maks = 0;
//for (int i = 0; i < T.Length; i++)
//{
//    if (maks < T[i])
//    {
//        maks = T[i];
//    }
//}
//for (int j = 0; j < T.Length; j++)
//{
//    if (mini > T[j])
//    {
//        mini = T[j];
//    }
//}
//maks = maks - mini;
//Console.WriteLine(maks);

//Zad.4
//int maks = 0;
//Array.Sort(T);
//Array.Reverse(T);
//maks = T[1];
//Console.WriteLine(maks);

//Zad.5
//int mini = 0;
//Array.Sort(T);
//mini = T[1];
//Console.WriteLine(mini);

//Zad.6
//int maks = 0;
//int ilo = 0;
//for (int i = 0; i < T.Length; i++)
//{
//    if (maks < T[i])
//    {
//        maks = T[i];
//    }
//}
//for (int j= 0; j < T.Length;j++)
//{
//    if (maks == T[j])
//    {
//        ilo += 1;
//    }
//}
//Console.WriteLine(ilo);

//Zad.7
//int ilo = 0;
//int mini = 101;
//for (int i = 0; i < T.Length; i++)
//{
//    if (mini > T[i])
//    {
//        mini = T[i];
//    }
//}
//for (int j = 0; j < T.Length; j++)
//{
//    if (mini == T[j])
//    {
//        ilo += 1;
//    }
//}
//Console.WriteLine(ilo);

//Zad.8
//int n =int.Parse(Console.ReadLine());
//int ilo = 0;
//for (int j = 0; j < T.Length; j++)
//{
//    if (n == T[j])
//    {
//        ilo += 1;
//    }
//}
//Console.WriteLine(ilo);

//Zad.9
//double suma = 0;
//for (int i=0; i <T.Length; i++)
//{
//    suma += T[i];
//}
//suma = suma / 40;
//Console.WriteLine(Math.Round(suma,1));

//Zad.10
//int suma = 0;
//for (int i = 0; i < T.Length; i = i + 2)
//{
//    suma++;
//}
//Console.WriteLine(suma);,

//Zad.10 - sposób 2
//int suma = 0;
//for(int i = 0; i < T.Length; i++)
//{
//    if(i==0 || i % 2 == 0)
//    {
//        suma = suma + T[i];
//    }
//}
//Console.WriteLine(suma);
