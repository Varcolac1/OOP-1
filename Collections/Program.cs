/*string[] names = new string[] {"Engin", "Murat", "Kerem", "Halil"};
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);

names = new string[5];   // Heap te yeni referans numarası alındığı için önceki arrayda tuttuğumuz değerleri kaybettik.
names[4] = "Alper";    
Console.WriteLine(names[4]);
Console.WriteLine(names[0]);
*/
List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
names2.Add("Alper");
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);
Console.WriteLine(names2[4]);