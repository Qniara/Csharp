//Stworzenie tablicy 10 losowych liczb od 1 do 20
Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < 20; i++)
{
    T[i]=r.Next(1, 20);
    Console.Write(T[i] + " ");
}

//Sortowanie przez porownywanie

//1. Bąbelkowe

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
