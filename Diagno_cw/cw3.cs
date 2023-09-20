bool CzyPie(int x)
{
    for(int i = 2; i < x; i++)
        if (i % x == 0) return false;
    return true;
}
//1.Napisz program, który pomnoży dwie macierze losowych liczb. 
//Niech user podający wymiary macierzy zadba o odpowiednie wymiary,
//tak aby mnożenie było możliwe. Macierze wypełnij losowymi liczbami.

//2. Napisz algorytm, który sprawdzi czy gdzieś w macierzy 10x10 losowych liczb dwucyfrowych
//doszło do sytuacji, że obok siebie są dwie liczby pierwsze.
//int[,] T = new int[10, 10];
//Random r=new Random();
//for(int i=0; i<10; i++)
//{
//    for(int j=0; j<10; j++)
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
//string a = Console.ReadLine();
//string b = Console.ReadLine();
//string a2 = a.Reverse().ToString();
//string b2 = b.Reverse().ToString();
//if (a == a2 && b == b2)
//    Console.WriteLine("TAK");
//else
//    Console.WriteLine("NIE");

//4. Napisz program, który znajdzie w podanej n-elementowej tablicy najdłuższy spójny podciąg niemalejący
//oraz obliczy jego długość i sumę jego elementów

//5. Wygeneruj macierz n x n z losowymi cyframi. Znajdź sumę tych elementów tej macierzy,
//które należą do którejkolwiek osi symetrii.
