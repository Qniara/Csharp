//Stworzenie tablicy 10 losowych liczb od 1 do 20
Random r = new Random();
int n = 10;
int[] T = new int[20];
for (int i = 0; i < 20; i++)
{
    T[i]=r.Next(1, 20);
    Console.Write(T[i] + " ");
}

//Sortowanie przez porownywanie

//1. Bąbelkowe
//od prawej rozsnąco
//int temp = 0;
//for (int i = n - 1; i >= 0; i--)
//{
//    for(int j = 0; j < i-1; j++)
//    {
//        if (T[j] > T[j + 1])
//        {
//            temp = T[j];
//            T[j] = T[j + 1];
//            T[j + 1] = temp;
//        }
//    }
//}

//2. Przez wybór

//3. Przez wstawianie

// Sortowania w czasie liniowym

//4. Przez zliczanie

//5. Kubełkowe

// Przez dzielenie

//6. Przez scalanie

//7. Quicksort Hoare

//8. Quicksort Lomuto

//Wyświetlanie posortowanej tablicy

//Console.WriteLine("\n");
//for(int i = 0; i < 20; i++)
//{

//}
