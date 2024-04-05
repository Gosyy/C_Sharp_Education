// Создать слово из букв

class Program
{
    public static string GetLettersFromString(string str)
    {
        string letters = "";
        foreach (char e in str)
        {
            if (char.IsAsciiLetter(e) == true)
            {
                letters += e;
            }
        }

        return letters;
    }

    public static void Main()
    {
        string str = Console.ReadLine();
        string result = GetLettersFromString(str);
        System.Console.Write(result);
    }
}
