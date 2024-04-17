//Zad.0
//Console.Write("Podaj 7 liczb: ");
//string cyfry = Console.ReadLine();
//string[] cyfry2 = cyfry.Split(' ');
//int[] cyfry3 = new int[7];
//for(int i = 0; i < 7; i++)
//{
//    cyfry3[i] = int.Parse(cyfry2[i]);
//}
//bool czyNieMalejaca = true;
//for(int i = 0;i < 6; i++)
//{
//    if (cyfry3[i] >= cyfry3[i+1]) czyNieMalejaca = false;
//}
//if (czyNieMalejaca == true) Console.WriteLine("Podana lista liczb jest wielkomiejska");
//else Console.WriteLine("Podana lista liczb jest malorolna");
////Lista cyfr niemalejaca i nierosnaca to np.
//int[] cyfry4 = { 1, 1, 1, 1, 1, 1, 1 };
//// i kazde inne dowolne cyfry byle by wszystkie takie same

//Zad.1
//Random r = new Random();
//int[] T = new int[10];
//List<int> podciag = new List<int>();
//List<int> maxpodciag = new List<int>();
//int suma = 0;
//for (int i = 0; i < 10; i++)
//{
//    T[i] = r.Next(-9, 9);
//    Console.Write(T[i] + " ");
//}
//for(int i = 0;i < 10; i++)
//{
//    if(T[i] > 0)
//    {
//        podciag.Add(T[i]);
//    }
//    else
//    {
//        if (podciag.Count > maxpodciag.Count)
//        {
//            maxpodciag=new List<int>(podciag);
//        }
//        podciag.Clear();
//    }
//}
//if(podciag.Count > maxpodciag.Count)
//{
//    maxpodciag = new List<int>(podciag);
//}
//foreach (int i in maxpodciag) suma += i;
//Console.WriteLine();
//Console.WriteLine("\nSuma elementow podciagu: " + suma);
//Console.WriteLine("\nPierwszy element podciagu: " + maxpodciag[0]);
//Console.WriteLine("\nOstatni element podciagu: " + maxpodciag[maxpodciag.Count - 1]);

//Zad.2
//Random r = new Random();
//int n = 3;
//int n2 = n;
//int suma1 = 0;
//int suma2 = 0;
//int[,,] T = new int[n, n, n];
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        for (int k = 0; k < n; k++)
//        {
//            T[i, j, k] = r.Next(10);
//            Console.Write(T[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        for (int k = 0; k < n; k++)
//        {
//            if (i == j && j == k && i == k) suma1 += T[i, j, k];
//            else if (i == 2 && k == 0 && j == 0) suma2 += T[i, j, k];
//            else if (i == 1 && k == 1 && j == 1) suma2 += T[i, j, k];
//            else if (i == 0 && k == 2 && j == 2) suma2 += T[i, j, k];
//        }
//    }
//}
//Console.WriteLine("\nSuma 1 przekatnej: " + suma1);
//Console.WriteLine("\nSuma 2 przekatnej: " + suma2);

//Zad.3
//Dictionary<int,List<int>> graf = new Dictionary<int,int>();
//Console.Write("Podaj ilosc wierzchokow: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj ilosc krawedzi: ");
//int k = int.Parse(Console.ReadLine());
//int iloscKrawedziWierzcholka = k / n;
