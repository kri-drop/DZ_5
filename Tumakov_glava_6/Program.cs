using Microsoft.VisualBasic;

class Program
{
    static (int CountVowels, int CountConsonants) CalculateLetters(string filePath)
    {
        string result = File.ReadAllText(filePath);

        char[] vovels = new char[] { 'а', 'о', 'у', 'ы', 'э', 'я', 'ё', 'ю', 'и', 'е' };
        char[] consonants = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };


        int countVovels = 0;
        int countConsonants = 0;

        foreach (var item in result)
        {
            if (vovels.Contains(item))
            {
                countVovels++;
            }
        }
        foreach (var item in result)
        {
            if (consonants.Contains(item))
            {
                countConsonants++;
            }
        }

        return (countVovels, countConsonants);
    }
    static void Task1()
    {
        string filePath = "..\\..\\..\\Files\\test.txt";
        var result = CalculateLetters(filePath);
        

        Console.WriteLine("Количество гласных букв: " + result.CountVowels);
        Console.WriteLine("Количество согласных букв: " + result.CountConsonants);

    }
    static void Main(string[] args)
    {
        Task1();
        Console.ReadKey();
    }
}
