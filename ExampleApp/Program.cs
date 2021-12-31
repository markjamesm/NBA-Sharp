using NBASharp;

namespace ExampleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var sampleBio = Api.GetPlayerBio("player_201935").GetAwaiter().GetResult();

        foreach (var item in sampleBio)
        {
            Console.WriteLine($"Id: {item.Id}");
            Console.WriteLine($"Display name: {item.DisplayName}");
            Console.WriteLine($"Professional: {item.Professional}");
            Console.WriteLine($"College: {item.College}");
            Console.WriteLine($"High school: {item.HighSchool}");
            Console.WriteLine($"Other label: {item.OtherLabel}");
            Console.WriteLine($"Other text: {item.OtherText}");
            Console.WriteLine($"Twitter: {item.Twitter}");
        }
    }
}