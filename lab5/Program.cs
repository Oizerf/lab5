//1
// int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
// int tura =0;
// int zlotoRazem =0;
// int powyzej =0;
// foreach (int zloto in zlotoWTurach)
// {
//     tura ++;
//     zlotoRazem += zloto;
//     Console.WriteLine($"Tura {tura}: {zloto} sztuk zlota");
//     if (zloto>=10)
//     {
//         powyzej++;
//     }
// }
// Console.WriteLine($"laczne zloto: {zlotoRazem}");
// double sredniaZlota=zlotoRazem/tura;
// Console.WriteLine($"srednia zlota na ture: {sredniaZlota}");
// Console.WriteLine($"tury z zlotem powyzej 10: {powyzej}");
// Console.Write("od konca: ");
// for (int i=zlotoWTurach.Length-1;i>=0;i--)
// {
//     Console.Write($"{zlotoWTurach[i]} ");
// }
//2
// using System.ComponentModel;
// using System.Threading.Tasks.Dataflow;
// List<string> plecak = new List<string>
// {
//     "miecz",
//     "Mikstura",
//     "Pochodnia",
// };
// Console.WriteLine($"liczba przedmiotow: {plecak.Count}");
// int pozycja =1;
// foreach (string przedmiot in plecak)
// {
//     Console.WriteLine($"{pozycja}. {przedmiot}");
//     pozycja ++;
// }
// Console.Write("znaleziony przedmiot: ");
// plecak.Add(Console.ReadLine());
// Console.WriteLine($"dodano: {plecak[plecak.Count-1]}");
// if (plecak.Contains("Mikstura"))
// {
//     Console.WriteLine("uzyto mikstury");
//     plecak.Remove("Mikstura");
// }
// else
// {
//     Console.WriteLine("brak mikstury w plecaku");
// }
// foreach (string przedmiot in plecak)
// pozycja =1;
// foreach (string przedmiot in plecak)
// {
//     Console.WriteLine($"{pozycja}. {przedmiot}");
//     pozycja ++;
// }
//3
// using System.Security.Cryptography;

// Dictionary<string, int> ceny = new Dictionary<string, int>
// {
    
//     {"mikstura", 15 },
//     {"pochodnia", 5},
//     {"miecz", 40}
// };
// Console.WriteLine($"{ceny.Count}");
// foreach (KeyValuePair<string, int> cena in ceny)
// {
//     Console.WriteLine($"{cena.Key} kosztuje: {cena.Value}");
// }
// Console.Write("wyszukaj przedmiot :");
// string nowyPrzedmiot = Console.ReadLine();
// bool jestPrzedmiot = ceny.ContainsKey(nowyPrzedmiot);
// if (jestPrzedmiot)
// {
//     Console.WriteLine($"{nowyPrzedmiot} kosztuje: {ceny[nowyPrzedmiot]}");
// }
// else
// {
//     Console.WriteLine("niema danego przedmiotu");
// }
// ceny["mikstura"] = 12;
// foreach (KeyValuePair<string, int> cena in ceny)
// {
//     Console.WriteLine($"{cena.Key} kosztuje: {cena.Value}");
// }
//4
Console.Write("ile tur: ");
int tury = int.Parse(Console.ReadLine());
int[] zlotoWTurach = new int[tury];
for (int i = 0 ; tury>i ; i++)
{
    tury[i] = int.Parse(Console.ReadLine());
}