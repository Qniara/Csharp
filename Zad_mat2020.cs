////Zad.1
//using System.IO;
//string[] S = File.ReadAllLines(@"C:\\Users\\uczen\\przyklad.txt");
//int[] L = new int[S.Length];
//string[] N = new string[S.Length];
//int g = 0;
//foreach (string item in S)
//{
//    L[g] = int.Parse((item.Split(" "))[0]);
//    N[g] = (item.Split(" "))[1];
//    g++;
//}

////string[] LINIA = new string[2];
////foreach (string item in S)
////{
////    LINIA = item.Split(" ");
////    L[i] = int.Parse(LINIA[0]);
////    N[i] = LINIA[1];
////    i++;
////}

////Zad.2
//bool f(int x)
//{
//    bool flaga = true;
//    for (int k = 2; k<x; k++)
//    {
//        if (x % k == 0)
//        {
//            flaga = false;
//        }
//    }
//    return flaga;
//}
//for  (int i = 0; i< L.Length; i++)
//{
//    if (L[i] > 4 && L[i] % 2 == 0)
//    {
//        for(int j=2; j < L[i]; j++)
//        {
//            if(f(j) && f(L[i] - j))
//            {
//                Console.WriteLine($"{L[i]} {j} {L[i] - 1}");
//                break;
//            }
//        }
//    }
//}
