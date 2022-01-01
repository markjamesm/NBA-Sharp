using NBASharp;

namespace ExampleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var nbaClient = new NBAClient();

        var sampleBio = nbaClient.GetPlayerBioAsync("player_201935").GetAwaiter().GetResult();

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

        var scoreboard = nbaClient.GetScoreboardAsync("20190201").GetAwaiter().GetResult();

        foreach (var item in scoreboard)
        {
            Console.WriteLine($"Arena: {item.Arena}");
            Console.WriteLine($"Game ID:{item.GameId}");
            Console.WriteLine($"Start time (UTC): {item.StartTimeUTC}");
            Console.WriteLine($"End time (UTC):{ item.EndTimeUTC}");
            Console.WriteLine($"Season Year:{item.SeasonYear}");
            Console.WriteLine($"Attendance : {item.Attendance}");
            Console.WriteLine($"Clock: {item.Clock}");
            Console.WriteLine($"Game duration: {item.GameDuration}");
            Console.WriteLine($"Tickets: {item.Tickets}");
            Console.WriteLine($"Stats num: {item.StatusNum}");
            Console.WriteLine($"Is buzzer beater: {item.IsBuzzerBeater}");
            Console.WriteLine($"Is game activated: {item.IsGameActivated}");
        }

        var teamRoster = nbaClient.GetTeamRosterBySlugAsync("2018", "pistons").GetAwaiter().GetResult();

        foreach (var item in teamRoster)
        {
            Console.WriteLine($"PlayerId: {item.PersonId}");
        }
    }
}