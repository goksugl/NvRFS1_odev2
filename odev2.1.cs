// See https://aka.ms/new-console-template for more information

// 1-   for döngüsü ile sayının toplamını bulan algoritmayı yazınız.

Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;

for (int i = 1; i <= sayi; i++)
{
    toplam += i;
}
Console.WriteLine("Toplam: " + toplam);

// 2-   while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız.
//      (10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste)

int sayi;
while (true)
{
    Console.Write("Bir sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi >= 10 && sayi <= 100)
    {
        Console.WriteLine("Geçerli sayı: " + sayi);
        break; 
    }
    else
    {
        Console.WriteLine("Lütfen 10 ile 100 arasında bir sayı girin.");
    }
}

// 3-   foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.
//      (0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı)

int[] yaslar = { 15, 23, 5, 67, 34, 8, 17, 65, 12 };
foreach (int yas in yaslar)
{
    if (yas >= 0 && yas <= 12)
    {
        Console.WriteLine($"Yaş: {yas} - Çocuk (0-12)");
    }
    else if (yas >= 13 && yas <= 19)
    {
        Console.WriteLine($"Yaş: {yas} - Genç (13-19)");
    }
    else if (yas >= 20 && yas <= 64)
    {
        Console.WriteLine($"Yaş: {yas} - Yetişkin (20-64)");
    }
    else if (yas >= 65)
    {
        Console.WriteLine($"Yaş: {yas} - Yaşlı (65+)");
    }
}

// 4-   bir dizide tekrar eden elemanları bulan algoritmayı yazınız.

int[] dizi = { 1, 2, 3, 4, 2, 5, 3, 6, 1 };

foreach (var eleman in TekrarEdenleriBul(dizi))
{
    Console.WriteLine(eleman);
}
static List<int> TekrarEdenleriBul(int[] dizi)
{
    HashSet<int> gorulenler = new HashSet<int>();
    List<int> tekrarEdenler = new List<int>();

    foreach (int eleman in dizi)
    {
        if (gorulenler.Contains(eleman) && !tekrarEdenler.Contains(eleman))
            tekrarEdenler.Add(eleman);

        gorulenler.Add(eleman);
    }

    return tekrarEdenler;
}


// 5-   bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.

string[] words = { "elma", "armut", "muz", "çilek", "karpuz", "kiraz" };

string shortest = words.OrderBy(word => word.Length).First();
string longest = words.OrderByDescending(word => word.Length).First();

Console.WriteLine($"En kısa kelime: {shortest}");
Console.WriteLine($"En uzun kelime: {longest}");

// 6-   kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.

Console.Write("Bir cümle girin: ");
string input = Console.ReadLine();

string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Array.Sort(words);

Console.WriteLine("\nAlfabetik sıralı kelimeler:");
foreach (string word in words)
{
    Console.WriteLine(word);
}

// 7-   Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.

string[] words = new string[0]; // Başlangıçta boş dizi
int count = 0;

while (true)
{
    Console.Write("Bir kelime girin (çıkmak için 'exit'): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    Array.Resize(ref words, words.Length + 1); // Diziyi 1 eleman genişlet
    words[count] = input;
    count++;
}

Console.WriteLine("\nGirilen kelimeler:");
foreach (string word in words)
{
    Console.WriteLine(word);
}

// 8-	Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.

List<string> words = new List<string>();

while (true)
{
    Console.Write("Bir kelime girin (çıkmak için 'exit'): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit") // Kullanıcı 'exit' yazarsa döngüyü bitir
        break;

    words.Add(input); // Kelimeyi listeye ekle
}

Console.WriteLine("\nKelime listesi (tersten):");

for (int i = words.Count - 1; i >= 0; i--)    //tersten yazdırma
{
    Console.WriteLine(words[i]);
}

// 9-	Kullanıcıdan ratgele sayılar alıp listeye ekleyen, bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

List<int> numbers = new List<int>(); 

while (true)
{
    Console.Write("Bir sayı girin (Çıkmak için 'exit'): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit") 
        break;

    if (int.TryParse(input, out int number)) // Geçerli bir sayı mı kontrol et
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir sayı girin.");
    }
}

if (numbers.Count > 0)
{
    double average = numbers.Average(); // Ortalama hesapla
    numbers.Sort(); // Küçükten büyüğe sırala

    Console.WriteLine($"\nGirilen sayıların ortalaması: {average:F2}");
    Console.WriteLine("Sıralı liste:");
    foreach (int num in numbers)
    {
        Console.Write(num + " ");
    }
}
else
{
    Console.WriteLine("Hiç sayı girilmedi.");
}

// 10-	Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.

List<int> numbers = new List<int> { 5, 12, 8, 20, 3, 15, 10, 25, 7 };

Console.WriteLine("Orijinal Liste:");
Console.WriteLine(string.Join(" ", numbers));

numbers.RemoveAll(n => n < 10);  // 10'dan küçük olanları sil


Console.WriteLine("\n10'dan küçük olanlar silindikten sonra:");
Console.WriteLine(string.Join(" ", numbers));

// 11-	Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

List<int> grades = new List<int> { 45, 78, 30, 90, 50, 20, 88, 49, 60 };

Console.WriteLine("Orijinal Notlar:");
Console.WriteLine(string.Join(" ", grades));

for (int i = 0; i < grades.Count; i++)  // 50'nin altındaki notları 50 yap

{
    if (grades[i] < 50)
    {
        grades[i] = 50;
    }
}

Console.WriteLine("\nGüncellenmiş Notlar:");
Console.WriteLine(string.Join(" ", grades));