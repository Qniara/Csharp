Console.WriteLine("Niech zyje krol Julian!");
// Tablice
//int a = 3;
//int b = 5;
//int c = 6;
//int d = 7;
//int e;
//int[] T = new int[4];
//T[0] = 3;
//T[1] = 5;
//T[2] = 6;
//T[3] = 7;
//for (int i = 1; i < T.Length; i++)
//{
//    Console.WriteLine(T[i]);
//}
//int[] K = { 2, 3, 5, 8, 13, 21, 34, 55 };
//for (int i = 0; i < K.Length; i++)
//{
//    Console.WriteLine($"{K[i]}");
//}
//int[] L;
//L = new int[] { 1, 2, 3 };

//Znajdz maksymalna wartosc tablicy [4,5,6,7,8,9]
//int[] K = new int[] { 4, 5, 8, 9, 7, 6 };
//int maks = 0;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] > maks)
//    {
//        maks = K[i];
//    }  
//}
//Console.WriteLine(maks);

// Znajdz mini wartosc tablicy [4,5,6,7,8,9]
//int[] K = new int[] { 4, 5, 8, 9, 7, 6 };
//int mini = 999999;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] < mini)
//    {
//        mini = K[i];
//    }
//}
//Console.WriteLine(mini);

//Tablica
int n =10;
int pocz = 1;
int kon = 20;
int[] K=new int[n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    K[i] = r.Next(pocz,kon);
}
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(J[i]+" ");
//}
//Zad.1
//Znajdź najwieksza liczba w tablicy
//int[] K = { 2, 3, 5, 8, 13, 21, 34, 55 };
//int maks = 0;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] > maks)
//    {
//        maks = K[i];
//    }
//}
//Console.WriteLine(max);

//Zad.2
//int[] K = { 2, 3, 5, 8, 13, 21, 34, 55 };
//int mini = 999999;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] < mini)
//    {
//        mini = K[i];
//    }
//}
//Console.WriteLine(mini);

//Zad.3
//Ile razy wystepuje najwieksza liczba w tablicy
//int maks = 0;
//int suma = 0;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] > maks)
//    {
//        maks = K[i];
//    }
//}
//for (int j = K[0]; j < K.Length; j++)
//{
//    if (j == maks)
//    {
//        suma = suma + 1;
//    }
//}
//Console.WriteLine(suma);

//Zad.4
//int mini = 999999;
//int suma = 0;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] < mini)
//    {
//        mini = K[i];
//    }
//}
//for (int j = K[0]; j < K.Length; j++)
//{
//    if (j == mini)
//    {
//        suma = suma + 1;
//    }
//}
//Console.WriteLine(suma);

//Zad.5
//int[] K = { 2, 3, 5, 8, 13, 21, 34, 55 };
//int mini = 999999;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] < mini)
//    {
//        mini = K[i];
//    }
//}
//int maks = 0;
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] > maks)
//    {
//        maks = K[i];
//    }
//}
//maks = maks - mini;
//Console.WriteLine(maks);

//Zad.6
//Suma liczb w tablicy
//int[] K = new int[] { 2, 3, 5, 8, 13, 21, 34, 55 };
//int suma = 0;
//for (int i = K[0]; i < K.Length; i++)
//{
//    suma = suma + i;
//}
//Console.WriteLine(suma);

//Zad.7
//int suma = 0;
//for (int i=0; i < K.Length; i++)
//{
//    suma = suma + i;
//}
//suma = suma /K.Length;
//Console.WriteLine(suma);

//Zad.8
//int suma = 0;
//int sum = 0;
//for (int i = 0; i < K.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        suma++;
//    }
//    else
//    {
//        sum++;
//    }
//}
//if (suma < sum)
//{
//    Console.WriteLine("Wiecej jest liczb parzystych");
//}
//else
//{
//    Console.WriteLine("Wiecej jest liczb nieparzystych");
//}

//Zad.9
//for (int i = 0; i < K.Length; i++)
//{
//    for (int j = 0; j < 100; j++)
//    {
//        if (i % j == 0)
//        {
//            Console.WriteLine();
//        }
//        else
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//Zad.10
//for (int i = 0; i < K.Length; i++)
//{
//    if (K[i] > maks)
//    {
//        maks = K[i];
//    }
//}
//int vcemaks = pocz;
//for (int i = 0; i<n; i++)
//{
//    if (T[i] > vcemaks && T[i] < maks)
//    {
//        vcemaks = T[i];
//    }
//}