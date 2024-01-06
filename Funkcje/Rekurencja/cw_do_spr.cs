//Zad.1
//Reku nww i nwd
int nwd_odej(int a, int b)
{
    if (a < b)
    {
        return nwd_odej(a, b - a);
    }
    if (a > b)
    {
        return nwd_odej(a - b, b);
    }
    return a;
}

int nwd_mod(int a, int b)
{
    if (b > 0)
    {
        return nwd_mod(b, a%b);
    }
    return a;
}

int nww(int a, int b)
{
    return a * b / nwd_odej(a, b);
}


//Console.WriteLine(nww(2, 4));
