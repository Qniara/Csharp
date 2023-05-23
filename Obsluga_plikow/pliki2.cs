using System.IO;

//Czytanie pliku
//var a = File.ReadAllText(@"C:\Users\admin\Desktop\Popr\C#\pliki\dokument.txt");
//var b = File.ReadAllLines(@"C:\Users\admin\Desktop\Popr\C#\pliki\dokument.txt");
//Console.WriteLine(a);
//Console.WriteLine();
//var x = string.Join(Environment.NewLine, b);
//Console.WriteLine(x);

//Zastepowanie tekstu w pliku
//Console.WriteLine("Insert name:");
//var name = Console.ReadLine();
//var x = File.ReadAllText(@"C:/Users/admin/Desktop/Popr/C#/pliki/dokument.txt");
//var document = x.Replace("{name}", name) .Replace("{datetime}", DateTime.Now.ToString());
//File.WriteAllText($"C:/Users/admin/Desktop/Popr/C#/pliki/dokument-{name}.txt", document);

//var y = File.ReadAllText($"C:/Users/admin/Desktop/Popr/C#/pliki/dokument-{name}.txt");
//Console.WriteLine(y);

//Dopisywanie do pliku
//var files =Directory.GetFiles("C:/Users/admin/Desktop/Popr/C#/pliki/", "*.txt", SearchOption.AllDirectories);
//foreach(string file in files)
//{
//    File.AppendAllText(file, "NIECH ZYJE KROL JULIAN");
//}

var files = Directory.GetFiles(sciezka, "nazwa pliku", Search.Option.AllDirectories);
foreach(string file in files)
  File.AppendAlltext(file, "text);
