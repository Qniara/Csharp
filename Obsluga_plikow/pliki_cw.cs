using System.IO;

//Czytanie pliku
//var a = File.ReadAllText(@"C:\Users\admin\Desktop\Popr\C#\pliki\dokument.txt");
//var b = File.ReadAllLines(@"C:\Users\admin\Desktop\Popr\C#\pliki\dokument.txt");
////Console.WriteLine(plik);
//Console.WriteLine();
//var x = string.Join(Environment.NewLine, b);
////Console.WriteLine(x);

//Zastepowanie tektu w pliku
Console.WriteLine("Insert name:");
var name = Console.ReadLine();
var x = File.ReadAllText(@"C:/Users/admin/Desktop/Popr/C#/pliki/write.txt");
var document = x.Replace("{name}", name);
File.WriteAllText($"C:/Users/admin/Desktop/Popr/C#/pliki/dokument-{name}.txt", document);
