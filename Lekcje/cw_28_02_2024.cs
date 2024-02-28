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
//List<char> LS = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
//List<string> S = new List<string>();
//List<char> LSC;
//Random r = new Random();
//int numer;
//for (int i = 0; i < 6; i++)
//{
//    LSC = LS.ToList();
//    S.Add("");
//    for(int j = 0; j < 3; j++)
//    {
//        numer = r.Next(0, LS.Count);
//        S[i] = S[i] + LSC[numer];
//        LSC.RemoveAt(numer);
//    }
//}
//foreach(var item in S)
//{
//    Console.Write(item + " "); 
//}

//Zad.4
//Stwórz kolejkę(queue) 4 losowych liczb fibonacciego < 100 (mogą się powtarzać). 
//Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2
//using System.Collections;
//int fibo(int n)
//{
//    if (n == 1) return 1;
//    if (n == 2) return 2;
//    return fibo(n - 1) + fibo(n - 2);
//}
//ArrayList FIBO = new ArrayList();
//int i = 1;
//while (fibo(1) < 100)
//{
//    FIBO.Add(fibo(i));
//    i++;
//}
//foreach (var item in FIBO)
//{
//    Console.WriteLine(item);
//}
//Random r = new Random();
//Queue q = new Queue();
//for(i = 0; i < 4; i++)
//{
//    q.Enqueue(FIBO[r.Next(0, FIBO.Count)]);
//}
//foreach (var item in q)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n");
//q.Dequeue();
//q.Dequeue();

//Zad.5
//Stwórz stos (stack) 5 kolejnych dwucyfrowych liczb pierwszych.
//Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.
//using System.Collections;
//int[] T = new int[5] { 11, 13, 17, 19, 23 };
//Stack stack = new Stack();
//for(int i = 0; i < 5; i++)
//{
//    stack.Push(T[i]);
//}
//foreach(var item in stack)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n");
//for(int j = 0; j < stack.Count; j++)
//{
//    Console.Write(stack.ElementAt(j) + " ");
//}
//Console.WriteLine("\n");
//stack.Pop();
//stack.Pop();
//stack.Pop();
//foreach (var item in stack)
//{
//    Console.Write(item + " ");
//}
