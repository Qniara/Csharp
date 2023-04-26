//Stworzenie tablicy 20 losowych liczb od 1 do 20
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
// wybieramy najmniejszy i wstawiamy go na początek
//int k;
//int temp = 0;
//for(int i = 0; i < n; i++)
//{
//    k = i;
//    for(int j = i + 1; j < n; j++)
//    {
//        if (T[j] > T[k])
//        {
//            k = j;
//            temp = T[i];
//            T[i] = T[k];
//            T[k] = temp;
//        }
//    }
//}

//wybieramy najmnijeszy i wstawiamy go na koniec
//int k;
//int temp;
//for(int i = n - 1; i > 0; i++)
//{
//    k = i;
//    for(int j = 0; j < i; j++)
//    {
//        if (T[j] < T[k])
//        {
//            k = j;
//        }
//        temp = T[i];
//        T[i] = T[k];
//        T[k] = temp;
//    }
//}

//3. Przez wstawianie
//int temp;
//int j;
//for (int i = 1; i < n; i++)
//{
//    temp = T[i];
//    j=i-1;
//    while (temp > T[j] && j>0)
//    {
//        T[j] = T[j - 1];
//        j--;
//    }
//    T[j-1] = temp;
//}

// Sortowania w czasie liniowym

//4. Przez zliczanie
//int[] L = new int[20];
//for(int i = 0; i < n; i++)
//{
//    L[T[i]]++;
//}
//for(int i = 0; i < L.Length; i++)
//{
//    Console.Write((L[i] + " "));
//}
//int j=0;
//for (int i = 0; i < L.Length; i++)
//{
//    if (L[i] > 0)
//    {
//        T[j] = i;
//        for(int k = 0; k < L[i]; k++)
//        {
//            T[j] = i;
//            j++;
//        }
//    }
//}

//5. Kubełkowe
//pominięte - na później

// Przez dzielenie

//6. Przez scalanie
//void scal(int l, int p)
//{
//    int[] pom = new int[n];
//    for (int j = 0; j < T.Length; j++)
//    {
//        pom[j] = T[j];
//    }
//    int i = l;
//    int sr = (l + p) / 2;
//    int il = l;
//    int ip = sr;
//    while (il <= ip)
//    {
//        if (pom[il] < pom[ip])
//        {
//            T[i] = pom[il];
//            il++;
//        }
//    }
//}
//void sort(int lewy, int prawy)
//{
//    int srodek = (lewy + prawy) / 2;
//    if (lewy > srodek)
//    {
//        sort(lewy, srodek);
//    }
//    if (prawy > srodek + 1)
//    {
//        sort(prawy, srodek + 1);
//    }
//    scal(lewy, prawy);
//}//XD

//7. Quicksort Hoare

//8. Quicksort Lomuto

//Wyświetlanie posortowanej tablicy

//Console.WriteLine("\n");
//for(int i = 0; i < 20; i++)
//{
//    Console.WriteLine(T[i] + " ");
//}
