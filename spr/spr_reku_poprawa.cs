//Zad.1
int nwd_mod(int a, int b)
{
    if (b > 0) return nwd_mod(b, a % b);
    return a;
}
//Console.WriteLine(nwd_mod(10,5));

//Zad.2
int fibo(int n, int a, int b)
{
    if (n > 0)
    {
        if (b % 2 == 0)
        {
            Console.WriteLine(b);
            return fibo(n - 1, b, a + b);
        }
    }
    return b;

}
//Console.WriteLine(fibo(7,0,1)); 

//Zad.3
int anagram(string n)
{
    int dlugosc = n.Length;
    int pom = n[0];
    n[0] = n[dlugosc];
    n[dlugosc] = pom;
    return anagram(n);
}
Console.WriteLine(anagram("kot"));
