namespace Zadanie3;

class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[] { "Ania", "Kasia", "Basia", "Zosia" };
        string[] surnames = new string[] { "Kowalska", "Nowak" };

        string filePath = $"dane-{DateTime.Now.ToString("dd_MM_yyyy_HH_mm")}.csv";
        
        using StreamWriter writer = new(filePath, false);
        writer.WriteLine("lp,name,surname,birthYear");
        Random random = new();
        for (int i = 1; i < 101; i++)
        {
            var name = names[random.Next(0, names.Length)];
            var surname = surnames[random.Next(0, surnames.Length)];
            writer.WriteLine($"{i},{name},{surname},{random.Next(1989,2001)}");
        }

        Console.WriteLine("Plik został zapisany w " + Path.GetFullPath(filePath));
    }
}