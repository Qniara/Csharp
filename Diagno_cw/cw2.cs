using System.Data;

int NWD(int x, int y)
{
    while (x != y)
    {
        if (x > y)
        {
            x = x - y;
        }
        else
        {
            y = y - x;
        }
    }
    return x;
}
int NWW(int x, int y)
{
    int z = x * y;
    while (x != y)
    {
        if (x > y)
        {
            x = x - y;
            z = z / x;
        }
        else
        {
            y = y - x;
            z = z / y;
        }
    }
    return z;
}
//1.User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//int iloczyn = x * y;
//for(int i=1; i<=iloczyn; i++)
//{
//    if(iloczyn %i==0 && NWD(i, iloczyn) == x && NWW(i, iloczyn/i) == y)
//    {
//        Console.WriteLine(i + " " + iloczyn / i);
//    }
//}


//2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.
//string pier = Console.ReadLine();
//string drug = Console.ReadLine();
//string[] P = pier.Split("/");
//string[] D = drug.Split("/");
//int a = int.Parse(P[0]);
//int b = int.Parse(P[1]);
//int c = int.Parse(D[0]);
//int d = int.Parse(D[1]);
//int mianownik = NWW(b, d);
//int licz1 = mianownik * a / b;
//int licz2 = mianownik * c / d;
//if(licz1 + licz2 > mianownik)
//{
//    Console.WriteLine("Jes");
//}
//else
//{
//    Console.WriteLine("Niet");
//}

//3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.
//string pier = Console.ReadLine();
//string drug = Console.ReadLine();
//string[] P = pier.Split("/");
//string[] D = drug.Split("/");
//int a = int.Parse(P[0]);
//int b = int.Parse(P[1]);
//int c = int.Parse(D[0]);
//int d = int.Parse(D[1]);
//int e = b;
//int f = a;
//int g = d;
//int h = c;
//int mian1 = NWW(b, d);
//int mian2 = NWW(f, h);
//int licz1 = mian1 * a / b;
//int licz2 = mian1 * c / d;
//int licz3 = mian2 * e / f;
//int licz4 = mian2 * g / h;
//int licznik = licz1 + licz2;
//int licznik2 =licz3 + licz4;
//int dupa = licznik / mian1;
//int pupa = licznik2 / mian2;
//if (dupa > pupa)
//{
//    Console.WriteLine("Normalna suma wieksza");
//}
//else
//{
//    Console.WriteLine("Odwrotna suma wieksza");
//}

//4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.
//char[] samogloski ={'a', 'i', 'e', 'u', 'o', 'y'};
//string napis = Console.ReadLine();
//int ilosc = 0;
//for(int i = 0; i < napis.Length; i++)
//{
//    if (samogloski.Contains(napis[i]))
//    {
//        ilosc++;
//    }
//    else
//    {
//        --ilosc;
//    }
//}
//if(ilosc>0)
//{
//    Console.WriteLine("Wiecej samogflosek");
//}
//else
//{
//    Console.WriteLine("Wiecej spolgklosek");
//}

//5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.
//string n = Console.ReadLine();
//int[] T = new int[300];
//int maks = 0;
//foreach (char a in n)
//{
//    int kod = (int)a;
//    T[kod] = T[kod] + 1;
//}
//for (int i = 0; i < T.Length; i++)
//{
//    if (T[i] > maks)
//    {
//        maks = i;
//    }
//}
//char litera = (char)maks;
//Console.WriteLine(litera);

//6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

//7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
//Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
//i lecąc z jednakową prędkością przybywają w tym samym czasie. 
//Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

//8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
//a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
//które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
//Napisz program, który pomaga w takich obliczeniach.

//9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody,
//zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład,
//jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
//będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4.Masz dane wszystkie liczby, które Halinka wypowiedziała 
//podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

//10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
//przechadzających się ludzi.
//W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
//obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
//znaleźć sobie miejsce na ławce.
//Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
//Jaka jest minimalna, a jaka maksymalna wartość k?


Console.WriteLine("DUPA");
