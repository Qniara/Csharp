//1.Wpisz do tablicy n liczb podanych przez usera w sposób 
//rosnący i wypisz te z nich, które są "portugalskie".
//Przez liczby portugalskie rozumiemy liczby samotne czyli takie które nie 
//mają sąsiada w otoczeniu 2.
//WE: 5
//3 7 9 13 19
//WY:
//3 13 19
//Console.WriteLine("Podaj liczbe: ");
//int n = int.Parse(Console.ReadLine());
//int[] T = new int[n];
//List<int> L = new List<int>();
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Podaj liczbe: ");
//    int a = int.Parse(Console.ReadLine());
//    T[i] = a;
//}
//for (int i = 0; i < n; i++)
//{
//    if (i == 0)
//    {
//        if (T[i] == T[i + 1] + 2 || T[i] == T[i + 1] - 2) L.Add(T[i]);
//    }
//    if (i == n)
//    {
//        if (T[i] == T[i - 1] + 2 || T[i] == T[i - 1] - 2) L.Add(T[i]);
//    }
//    if(T[i] == T[i - 1] + 2 || T[i] == T[i - 1] - 2) L.Add(T[i]);
//    if (T[i] == T[i + 1] + 2 || T[i] == T[i + 1] - 2) L.Add(T[i]);
//}
//foreach (int i in L)
//{
//    Console.Write(i + " ");
//}

//2.User podaje dowolny werset z Pana Tadeusza. Sprawdź czy w tym wersecie jakaś
//literka występuje co najmniej 3 razy. Użyj tablic (toCharArray())

//3. User podaje dwie liczby brytyjskie. Przez liczby brytyjskie rozumiemy dwie 
//dowolne liczby dwucyfrowe różniące się przynajmniej o 50.
//Zapisz do listy wszystkie liczby pierwsze znajdujące się 
//między powyższymi liczbami.

//4. Utwórz strukturę losowych osób z losowymi danymi. Zasady:
//-wiek między 20 a 50 lat
//- imię 4 literowe zaczynająca się na A.
//- Nazwisko to odwrócenie imienia.
//Wylosuj takie 4 osoby i dodaj je do listy Osób. User nic tu nie wprowadza.

//5. Utwórz kolejkę liczb doskonałych 
//(liczby które równają się sumie swoich dzielników właściwych). 
//Umieść w niej 4 najmniejszych liczb doskonałych.
//Wyświtl kolejkę, usuń z niej 2 liczby i znów wyświtl to co zostało.

//6. Stwórz stos nieparzystych dwucyfrowych wieloktorności liczby 13.
//Usuń z tego stosu 2 liczby i wyświetl znów ten stos 
//dziwiąc się temu co na nim zostało.

//7. Kod Hufmanna to zamiana ciągu w stylu AAAAABBBBBBBCCC na 5A7B3C.
//Niech user poda wam n ciągów które zapiszecie to zwykłej tablicy.
//Potem przenieście te dane do słowinika, gdzie kluczem będzie kod ciągu
//a wartością ten ciąg.

//8. Stwórz graf składający się z 6 wierzchołków i 7 krawędzi. 
//Wypisz najwyższy stopień wierzchołka. Jeśli kilka wierzchołków ma ten sam stopień
//to wypisz dowolny z nich.

//-----------------------------------------------------------------------------------

//1.Wpisz do tablicy T 5 losowych liczb dwucyfrowych.
//Stworz tablice W liczb parzystych zanjdujacych sie miedzy minimalna
//a maksymalna wartoscia z tablicy T
//int[] T = new int[5];
//Random r = new Random();
//List<int> W = new List<int>();
//int maks = 0;
//int min = 0;
//for (int i = 0; i < 5; i++)
//{
//    T[i] = r.Next(100);
//    Console.Write(T[i] + " ");
//}
//for(int i = 0;i < 5; i++)
//{
//    if (T[i] > maks)
//    {
//        maks= T[i];
//    }
//    if(i==0) min = i;
//    if (T[i] < min)
//    {
//        min = T[i];
//    }
//}
//Console.WriteLine();
//for(int i= min; i< maks-1; i++)
//{
//    if (i % 2 == 0)
//    {
//        W.Add(i);
//        Console.Write(i + " ");
//    }
//}

//2. Utworz ArrayListe A zawierającą 10 losowych słów 3-literowych.
//Wypisz słowo o największej sumie kodów ASCII jego liter
//using System.Collections;
//ArrayList A = new ArrayList();
//Random r = new Random();
//string s = "";
//int suma = 0;
//int maks = 0;
//int x = 0;
//int[] T = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    for(int j = 0; j < 3; j++)
//    {
//        int a = r.Next(65, 91);
//        suma = suma + a;
//        s = s + (Convert.ToChar(a)).ToString();
//    }
//    T[i] = suma;
//    A.Add(s);
//}
//for(int i = 0;i < 10; i++)
//{
//    if (maks < T[i])
//    {
//        maks = T[i];
//        x = i;
//    }
//}
//Console.WriteLine($"Wyraz {A[x]} ma najwieksza sume kodow ascii.");



//3.Stworz liste L skladajaca sie z 10 list i 10 losowych cyfr.
//Oblicz sume najwiekszych cyfr w listach listy L oraz 
//sprawdz czy istenieje
