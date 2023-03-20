bool czypie(int x)
{
    bool flaga = true;
    for(int i = 2; i < x; i++)
    {

        if (x % i == 0)
        {
            flaga = false;
        }
    }
    return flaga;
}
string[] liczby = System.File.IO.ReadAllLines(@"sciezka do pliku");
