//Tablice 
int[] T = new int[3]; // deklaracja tablicy
T[0] = 4;
T[1] = 8;
T[2] = 9;//deklaracja definiuje nazwe a definicja przypisuje wartość

//Deklaracja i definicja w jednym
int[] D = new int[] { 5, 8, 12, 16 };

//Przechodzenie po tablicy - 2 pętle (for i foreach)
for(int i=0;i<D.Length; i++)
{
    Console.WriteLine(D[i] + " ");
}
Console.WriteLine("\n");
