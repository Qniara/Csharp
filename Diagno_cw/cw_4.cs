Console.WriteLine("Dupa <3");
// Horner
//int p = int.Parse(Console.ReadLine());
//string a = Console.ReadLine();
//int w = 0;
//w = (int)a[0] - 48; // zamiana z kodu ascii
//for (int i = 1; i < a.Length; i++)
//{
//    w = p * w + (a[i]-48);
//}
//Console.WriteLine(w);
//w = Convert.ToInt32(Convert.ToString(a[0]));
//w = (int)char.GetNumericValue(a[0]) // to jest double i to jest to samo co to na górze z tym 48

//Konwersja bin -> dec i odwrotnie
//jakieś moje nei działające gówno
//int n = int.Parse(Console.ReadLine());
//double[] T = new double[n];
//double[] A = new double[n];
//n = (int)(double)n;
//for (int i = 0; i < T.Length; i++)
//{
//    T[i] = Math.Pow(2, i);
//}
//while (n == 0)
//{
//    double a = n;
//    for (int i = n; i < 0; i--)
//    {
//        if (T[i] <= n)
//        {
//            n = (int)(n - T[i]);
//        }
//    }
//}

//działający rpogram przepisany od nowaka
//string a=Console.ReadLine();
//int w = 0;
//for(int i=a.Length-1; i>=0; i--)
//{
//    w = w + (a[i] - 48) * (int)Math.Pow(2, a.Length - i - 1);
//}
//Console.WriteLine(w);
