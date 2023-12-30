namespace sayf112;
//ToLower() metodunu kullanmadan büyük harfleri küçük harfe dönüştüren C# progamını kodlayınız.
class Program
{
    static string ConvertToLowerCase(string değer)
    {
        char[] charArray = değer.ToCharArray(); //tek karakter dizisi

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i])) //buyuk harfmı kontrol et
            {
                // ASCII değeri arasındaki farkı kullanarak büyük harfi küçük harfe çevir
                charArray[i] = (char)(charArray[i] + 32);
            }
        }

        return new string(charArray); //yeni diziyi yaz stringe cevırıyor aynı zamanda
    }

    static void Main(string[] args)
    {

        Console.Write("Büyük harf içeren bir metin girin: ");
        string değer = Console.ReadLine();

        string dönüştür = ConvertToLowerCase(değer);

        Console.WriteLine("Küçük harfe dönüştürülmüş metin: " + dönüştür);

        Console.ReadLine();
    }
}

