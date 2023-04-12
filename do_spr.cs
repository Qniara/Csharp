using System.IO;
//Funkcje
//1
//int n = int.Parse(Console.ReadLine());
//int f(int x)
//{
//    //int a = 0;
//    int suma = 0;
//    while (x > 0)
//    {
//        //a = x % 10;
//        //x = x - a;
//        //suma = suma + a;
//        suma = suma + n % 10;
//        n = n / 10;
//    }
//    return suma;
//}
//Console.WriteLine(f(n));

//2
//string napis = "Basia";
//char[] C = napis.ToCharArray();
//Array.Reverse(C);
//string wynik = new string(C);
//Console.WriteLine(wynik);

//3
//int n = int.Parse(Console.ReadLine());
//int f(int x)
//{
//    while (x > 0)
//    {
//        Console.Write(x + "-");
//        x = x / 2;
//    }
//    return 0;
//}
//Console.WriteLine(f(n));

//Ciagi
//1
//int reku1(int n)
//{
//    if (n == 1)
//    {
//        return 3;
//    }
//    else
//    {
//        return reku1(n - 1) + 2;
//    }
//}
//int x = int.Parse(Console.ReadLine());
//for (int i =1; i <= x; i++)
//{
//    Console.WriteLine(reku1(i));
//}
//2

// Pliki
//1
//var files = Directory.GetFiles("C:\\Users\\uczen\\Dokumenty\\", "plik.txt", SearchOption.AllDirectories);
//foreach (string file in files)
//{
//    File.AppendAllText(file, DateTime.Now.ToString());
//}

//2
Random r = new Random();
string sciezka = "C:/Users/uczen/plik.txt";
for (int i=0; i<10; i++)
{
    int lb = r.Next(10,100);
    using (StreamWriter writer = File.AppendText(sciezka))
    {
        writer.WriteLine(lb);
    }
}
var x = File.ReadAllText(sciezka);
var y = File.ReadAllLines(sciezka);
int[] T = new int[10];

Console.WriteLine(x);
