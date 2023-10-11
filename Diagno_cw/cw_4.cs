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

//wariant 1 dec->bin
//int p =int.Parse(Console.ReadLine());
//string w = "";
//while (p > 0)
//{
//    w = p % 2 + w;
//    p = p / 2;
//}
//Console.WriteLine(w);

//wariant 2 -rekurencja
//void d2b(int p)
//{
//    if(p == 0)
//    {
//        return;
//    }
//    d2b(p/2);
//    Console.Write(p%2);
//}
//d2b(11);

//int[,] T = new int[20, 20];
//Random r= new Random();
//for(int i = 0; i < 20; i++)
//{
//    for(int j = 0; j < 20; j++)
//    {
//        T[i, j] = r.Next(0,100);
//    }
//}
//int suma = 0;
//int ilosc = 0;
//for (int i = 0; i < 20; i++)
//{
//    for (int j = 1; j < 19; j++)
//    {
//        suma = T[i, j - 1] + T[i, j + 1];
//        if (suma == T[i, j])
//        {
//            ilosc++;
//        }
//    }
//}
//Console.WriteLine(ilosc);
