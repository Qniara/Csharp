//Zad.1 - pom
int iloczyn(int x, int y)
{
    if (y == 1)
    {
        return x;
    }
    else
    {
        int k = y / 2;
        int z = iloczyn(x, k);
        if (y % 2 == 0) return z + z;
        if (y % 2 == 1) return z + z + x;
    }
    return 0;
}
//Zad.3.1
bool Zr(string x)
{
    int z = 0;
    int j = 0;
    foreach(char item in x)
    {
        if (item == '0') z++;
        if (item == '1') j++;
    }
    if (z == j) return true;
    return false;
}
bool Pzr(string x)
{
    int z = 0;
    int j = 0;
    foreach (char item in x)
    {
        if (item == '0') z++;
        if (item == '1') j++;
    }
    if (z + 1 == j || j == z + 1) return true;
    return false;
}
StreamReader sr = new StreamReader(@"C:\Users\admin\Desktop\Popr\C#\matura_czerwiec_2023\anagram.txt");
List<string> list = new List<string>();
list.Add(sr.ReadLine());
int i = 0;
int j = 0;
foreach(string item in list)
{
    if (Zr(item) == true) i++;
    if (Pzr(item) == true) j++;
}
Console.Write($"Liczb zrownowazonych jest {i}");
Console.Write($"Liczb prawie zrownowazonych jest {j}");
sr.Close();
