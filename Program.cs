// Pentla While

//Przypomnienie fora i zamiana na while

//Wypisanie cyfr od 1 do 9

//for (int m == 1; m < 10; m++)
//    Console.WriteLine(m);
//Console.WriteLine();

//int i = 1;
//while(i < 10)
//{
//    Console.WriteLine(i++ + " ");
//}
//Console.WriteLine();

//int k = 1;
//do
//{
//    Console.Write(k++);
//}while(k < 10);

// Petla nieskonczona
//for (; ; )
//{
//    Console.WriteLine("Niech zyje krol julian!");
//}
//int m = 0;
//while (true)
//{
//    Console.WriteLine("Niech zyje krol julian!");
//}
//int i = 0;
//do
//{
//    Console.WriteLine("Niech zyje krol julian");
//}while (true);

//Petla while wypisujaca malejaca liczby 2 cyfrowe niepodzielne przez 3
//int i = 99;
//while (i >= 10)
//{
//    i--;
//    if (i % 3 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

// Karta Pracy 3 w while
//Zad.1
//int n = int.Parse(Console.ReadLine());
//int i = 0;
//while (i < n)
//{
//    i++;
//    Console.Write(i*i*i + 3 + " ");
//}

//Zad.2
//int i = 100;
//while (i < 1000)
//{
//    i++;
//    if (i % 15 == 0)
//    {
//        Console.WriteLine(i + " ");
//    }
//}

//Zad.3
//int n = int.Parse(Console.ReadLine());
//int i = 0;
//while(i <= n)
//{
//    i++;
//    if (n % i == 0)
//    {
//        Console.Write(i+" ");
//    }
//}

//Zad.4
//int suma = 0;
//int i = 10;
//while (i < 100)
//{
//    i++;
//    suma = suma + i;
//}
//Console.WriteLine(suma);

//Zad.5
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//int suma = n * (n + 1) / 2;
//while (i < n)
//{
//    int x = int.Parse(Console.ReadLine());
//    suma = suma - x;
//    i = i + 1;
//}
//Console.WriteLine("Nie podales " + suma);

//Zad.6
//int n = int.Parse(Console.ReadLine());
//int a = 0;
//int b =1;
//int i = 0, temp;
//while(i < n)
//{
//    i = i + 1;
//    temp = a;
//    a = b;
//    b = temp + b;
//    Console.Write(b + " ");
//}
//Console.WriteLine();

//Zad.dom.
//Oblicz sume cyfr podanej liczby n (modulo 10)