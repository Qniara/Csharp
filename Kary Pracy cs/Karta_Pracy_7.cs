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
