//Zad.1
//Wygeneruj tablice 15 losowych liczb dwucyfrowych nieparzystych
//int[] T = new int[15];
//int x = 1;
//Random r = new Random();
//while (x < 15)
//{
//    for (int i = 0; i < x; i++)
//    {
//        T[i] = r.Next(10, 100);
//        if (T[i] % 2 == 1)
//        {
//            Console.WriteLine(x + ". " + T[i] + " ");
//            x = x + 1;
//        }
//    }
//}

//Zad.2
//Wygeneruj tablice 20 dowolnych liczb 2cyfrowych i zaokrąglij każdą w góre do pełnej 10
int[] T = new int[20];
Random r = new Random();
for (int i = 0; i < 20; i++)
{
    T[i] = r.Next(10, 100);
    if (T[i] % 2 == 1)
    {
        Console.WriteLine(i + ". " + T[i] + " ");
    }
}
