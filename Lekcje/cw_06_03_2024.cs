//Slowniki
Dictionary<string, List<int>> D1 = new Dictionary<string, List<int>>();
D1["dupa"] = new List<int>() { 10, 20, 30 };
D1["kupa"] = new List<int> { 20, 30 };
D1["pupa"] = new List<int>() { 1, 5, 8 };
//foreach(var item in D1)
//{
//    Console.Write(item.Key + " ");
//}
//Console.WriteLine("\n");
//foreach (var item in D1)
//{
//    Console.Write(item.Key + " - ");
//    foreach (var item1 in D1.Values)
//    {
//        foreach(var item2 in item1)
//        {
//            Console.Write(item2 + " ");
//        }
//    }
//    Console.WriteLine();
//}
//Dictionary<int, List<string>> D2 = new Dictionary<int, List<string>>();
//{
//    { 1,["dupa", "dupa"]}
//    { 2,["kupa","kupa"] }
//    { 3,["pupa","pupa"]}
//}

//Zad.6
Dictionary<int, List<int>> G = new Dictionary<int, List<int>>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    G.Add(i + 1, new List<int>());
}
int k = int.Parse(Console.ReadLine());
string[] liczby = new string[2];
for (int i = 0;i < k; i++)
{
    liczby = Console.ReadLine().Split();
    G[int.Parse(liczby[0])].Add(int.Parse(liczby[1]));
    G[int.Parse(liczby[1])].Add(int.Parse(liczby[0]));
}
