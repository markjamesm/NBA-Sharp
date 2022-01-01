using System.Text.Json;
using NBASharp.Model;
using NBASharp.ModelDto;
using PlayerBioModel = NBASharp.Model.PlayerBioModel;

namespace NBASharp;

/// <summary>
/// The Api class holds all NBA API endpoints that can be accessed from NBA Sharp.
/// </summary>
public class NBAClient : INBAClient
{
    private static HttpClient _httpClient = new HttpClient();
    private const string _baseUrl = "https://data.nba.net/";

    private async Task<string> GetResponseAsync(string endpoint)
    {

        var returnMessage = await _httpClient.GetAsync(_baseUrl + (endpoint ?? "")).ConfigureAwait(false);

        return await returnMessage.Content.ReadAsStringAsync();
    }

    /// <summary>
    /// Returns a player bio for a given player id.
    /// </summary>
    /// <param name="playerId">The ID of the player.</param>
    /// <returns>A list of player bio objects.</returns>
    public async Task<IEnumerable<PlayerBioModel>> GetPlayerBioAsync(string playerId)
    {
        var playerBioModel = new List<PlayerBioModel>();
        var response = await GetResponseAsync("json/bios/" + playerId + ".json");
        var playerBioRootDto = JsonSerializer.Deserialize<PlayerBioRootDto>(response);

        playerBioModel.Add(new PlayerBioModel()
        {
            Id = playerBioRootDto.Bio.id,
            Type = playerBioRootDto.Bio.type,
            College = playerBioRootDto.Bio.college,
            DisplayName = playerBioRootDto.Bio.display_name,
            HighSchool = playerBioRootDto.Bio.highschool,
            OtherLabel = playerBioRootDto.Bio.other_label,
            OtherText = playerBioRootDto.Bio.other_text,
            Professional = playerBioRootDto.Bio.professional,
            Twitter = playerBioRootDto.Bio.twitter
        });

        return playerBioModel;
    }

    /// <summary>
    /// Returns a scoreboard summary for the given date. Can be used to get GameIds.
    /// </summary>
    /// <param name="date">The date the games took place in YYYMMDD format (eg: 20190201).</param>
    /// <returns>A list of game objects for a specified date</returns>
    public async Task<IEnumerable<GameModel>> GetScoreboardAsync(string date)
    {
        var scoreboardModel = new List<GameModel>();
        var response = await GetResponseAsync("prod/v2/" + date + "/scoreboard.json");
        var scoreboardRootDto = JsonSerializer.Deserialize<ScoreboardRootDto>(response);

        foreach (var score in scoreboardRootDto.games)
        {
            scoreboardModel.Add(new GameModel()
            {
                Attendance = score.attendance,
                Clock = score.clock,
                EndTimeUTC = score.endTimeUTC,
                ExtendedStatusNum = score.extendedStatusNum,
                GameId = score.gameId,
                HasGameBookPdf = score.hasGameBookPdf,
                IsBuzzerBeater = score.isBuzzerBeater,
                SeasonStageId = score.seasonStageId,
                SeasonYear = score.seasonYear,
                IsGameActivated = score.isGameActivated,
                StatusNum = score.statusNum,
                StartTimeEastern = score.startTimeEastern,
                StartTimeUTC = score.startTimeUTC,
                StartDateEastern = score.startDateEastern,
                IsStartTimeTBD = score.isStartTimeTBD,
                IsPreviewArticleAvail = score.isPreviewArticleAvail,
                IsRecapArticleAvail = score.isRecapArticleAvail,

                /* Need to populate these at some point
                VTeam
                Watch
                Nugget,
                Watch,
                HTeam
                Period
                */
            });
        }

        return scoreboardModel;
    }
}