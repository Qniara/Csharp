bool CzyPie(int x)
{
    for(int i = 2; i < x; i++)
        if (i % x == 0) return false;
    return true;
}
//1.Napisz program, który pomnoży dwie macierze losowych liczb. 
//Niech user podający wymiary macierzy zadba o odpowiednie wymiary,
//tak aby mnożenie było możliwe. Macierze wypełnij losowymi liczbami.
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());
//int[,] A = new int[a, b];
//int[,] B = new int[c, d];
//Random r = new Random();
//if (a == d)
//{
//    for (int i = 0; i < a; i++)
//    {
//        for(int j = 0; j < b; j++)
//        {
//            A[i, j] = r.Next(1,100);
//        }
//    }
//    for (int i = 0; i < c; i++)
//    {
//        for (int j = 0; j < d; j++)
//        {
//            A[i, j] = r.Next(1, 100);
//        }
//    }
//}

//2. Napisz algorytm, który sprawdzi czy gdzieś w macierzy 10x10 losowych liczb dwucyfrowych
//doszło do sytuacji, że obok siebie są dwie liczby pierwsze.
//int[,] T = new int[10, 10];
//Random r = new Random();
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        T[i, j] = r.Next();
//    }
//}
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        if (CzyPie(T[i, j]) == true && CzyPie(T[i, j + 1]))
//        {
//            Console.WriteLine("doszlo");
//            break;
//        }
//    }
//}
//Console.WriteLine("nie doszlo");


//3. Napisz program, który sprawdzi, czy dwa słowa wpisane przez usera są anagramami
//string f(string n)
//{
//    char[] T = n.ToCharArray();
//    for (int i = 0, j = n.Length - 1; i < j; i++, j--)
//    {
//        T[i] = n[j];
//        T[j] = n[i];
//    }
//    string temp = new string(T);
//    return temp;
//}
//string a = Console.ReadLine();
//string b = Console.ReadLine();
//string temp = f(b);
//if (a == temp)
//    Console.WriteLine("TAK");
//else
//    Console.WriteLine("NIE");

//4. Napisz program, który znajdzie w podanej n-elementowej tablicy najdłuższy spójny podciąg niemalejący
//oraz obliczy jego długość i sumę jego elementów

//5. Wygeneruj macierz n x n z losowymi cyframi. Znajdź sumę tych elementów tej macierzy,
//które należą do którejkolwiek osi symetrii.
