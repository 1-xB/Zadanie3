namespace Zadanie3;

class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[] { "Ania", "Kasia", "Basia", "Zosia" };
        string[] surnames = new string[] { "Kowalska", "Nowak" };

        using StreamWriter writer = new("dane.csv", false);
        writer.WriteLine("lp,name,surname,birthYear");
        Random random = new();
        for (int i = 1; i < 101; i++)
        {
            var name = names[random.Next(0, names.Length)];
            var surname = surnames[random.Next(0, surnames.Length)];
            writer.WriteLine($"{i},{name},{surname},{random.Next(1989,2001)}");
        }
    }
}