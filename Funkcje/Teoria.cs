//Szablon: 
//typ_wyniku nazwa(arg) 
//{ 
// instrukcje 
// return? -> opcjonalnie 
//}

//void przywitaj() 
//{ 
// Console.WriteLine("Cześć"); 
//} 
//przywitaj();

//Funkcja obliczająca sumę 2 podanych liczb

//int suma(int a, int b) 
//{ 
// return a + b; 
//} 
//Console.WriteLine(suma(4, 6));

//Funkcja odwracająca stringa
//string odwrocStringa(string napis) 
//{ 
// char[] chars = napis.ToCharArray(); 
// Array.Reverse(chars); 
// return new string(chars); 
//} 
//Console.WriteLine(odwrocStringa("metorwop z i mat ilyzc tibboH"));

//Funkcja, która przyjmuję dowolną ilość argumentów
//suma wszystkich argumentów
//int bigsuma(int[] T)
//{
//    int suma = 0;
//    foreach(int item in T)
//    {
//        suma+= item;
//    }
//    return suma;
//}
//Console.WriteLine(bigsuma(new int[] { 1, 2, 3 }));

//Rekurencja UwU
int x=int.Parse(Console.ReadLine());
void rekul(int n)
{
    if (n == 0) return;
    rekul(n - 1);
    Console.Write(n + " ");
}
rekul(x);
