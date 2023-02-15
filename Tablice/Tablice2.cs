//Tablice 
//int[] T = new int[3]; // deklaracja tablicy
//T[0] = 4;
//T[1] = 8;
//T[2] = 9;//deklaracja definiuje nazwe a definicja przypisuje wartość

//Deklaracja i definicja w jednym

//int[] D = new int[] { 5, 8, 12, 16 };

//Przechodzenie po tablicy - 2 pętle (for i foreach)
//for (int i=0;i<D.Length; i++)
//{
//    Console.WriteLine(D[i] + " ");
//}
//Console.WriteLine("\n");

//foreach (var item in D)
//{
//    Console.WriteLine(item + " ");
//}
//Console.WriteLine("\n");

//Tablice dwuwymiarowe
int[,] M = new int[2, 3];
M[0, 0] = 3;
M[0, 1] = 4;
M[0, 2] = 5;
M[1, 0] = 8;
M[1, 1] = 9;
M[1, 2] = 10;

int[,] N = new int[4,3] { { 2, 3, 4 }, { 7, 8, 9 }, { 13, 14, 15 }, { 21, 31, 41 } };
for(int i = 0; i < N.Length; i++) //0-11
{
    Console.Write(N[i / 3, i % 3] + " ");
}
Console.WriteLine("\n");
