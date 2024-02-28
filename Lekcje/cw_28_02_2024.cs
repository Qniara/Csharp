//Zad.1
//Stwórzcie tablicę 115 pierwszych liczb, które w repreznetacji binarnej kończą się na 11
//11, 111, 1011, 1111, .....
//double[] T = new double[115];
//double suma = 0;
//int x = 0;
//for (double i = 0; i < 115; i++)
//{
//    suma = suma + (Math.Pow(2, i));
//    T[x] = suma;
//    x++;
//}
//for(int i = 0; i < T.Length; i++)
//{
//    Console.Write(T[x] + " ");
//}

//nowaka sposob
//int[] T = new int[115];
//T[0] = 3;
//for(int i = 1; i < T.Length; i++)
//{
//    T[i] = T[i - 1] + 4;
//}
//for(int i = 1; i < T.Length; i++)
//{
//    Console.Write(T[i] + " ");
//}

//Zad.2
//Stwórzcie plik o nazwie osoby z zawartością 5 osob: imie; nazwisko ; wiek. i wstawcie
//do tablicy obiekty (struktury) typu osoba z właściwościami / polami z pliku, czyli
//imie, nazwisko, wiek
//plik stworzyc wczesniej i zapelnic informacjami
//StreamReader sr = new StreamReader(@"C:\Users\emend\Desktop\Ziemniak\,\popr\cw_28_02_2024\osoby.txt");
//string[] linia = new string[3];
//int licznik = 0;
//Osoba[] Osoby = new Osoba[4];
//while (!sr.EndOfStream)
//{
//    linia=sr.ReadLine().Split(";");
//    Console.WriteLine(linia);
//    Osoba os;
//    os.imie = linia[0];
//    os.nazwisko = linia[1];
//    os.wiek = int.Parse(linia[2]);
//    Osoby[licznik]=os;
//    licznik++;
//    Console.WriteLine($"{os.imie} ; {os.nazwisko} ; {os.wiek}");
//}
//sr.Close();
//struct Osoba
//{
//    public string imie;
//    public string nazwisko;
//    public int wiek;
//}

//Zad.3
//Stwórz listę 6 losowych słów składających się z 3 różnych samogłsek (List, ArrayList)

//Zad.4
//Stwórz kolejkę(queue) 4 losowych liczb fibonacciego < 100 (mogą się powtarzać). 
//Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2

//Zad.5
//Stwórz stos (stack) 5 kolejnych dwucyfrowych liczb pierwszych.
//Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.
