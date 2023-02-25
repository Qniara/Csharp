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
