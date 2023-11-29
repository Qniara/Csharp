//REKURENCJA
for(int i = 1; i <= 5; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();
void re1(int n)
{
    Console.Write(n + " ");
    if (n == 5) return;
    else re1(n + 1);
}
re1(1);
