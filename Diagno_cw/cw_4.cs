Console.WriteLine("Dupa <3");
// Horner
int p = int.Parse(Console.ReadLine());
string a = Console.ReadLine();
int w = 0;
w = (int)a[0] - 48; // zamiana z kodu ascii
for (int i = 1; i < a.Length; i++)
{
    w = p * w + (a[i]-48);
}
Console.WriteLine(w);
//w = Convert.ToInt32(Convert.ToString(a[0]));
//w = (int)char.GetNumericValue(a[0]) // to jest double i to jest to samo co to na górze z tym 48
