using System.Text.Json;
using NBASharp.ModelDto;
using PlayerBioModel = NBASharp.Model.PlayerBioModel;

namespace NBASharp;

/// <summary>
/// The Api class holds all NBA API endpoints that can be accessed from NBA Sharp.
/// </summary>
public static class Api
{
    private static HttpClient _httpClient = new HttpClient();
    private const string _baseUrl = "https://data.nba.net/";

    private static async Task<string> GetResponse(string? endpoint)
    {

        var returnMessage = await _httpClient.GetAsync(_baseUrl + (endpoint ?? "")).ConfigureAwait(false);

        return await returnMessage.Content.ReadAsStringAsync();
    }

    /// <summary>
    /// Returns a player bio for a given player id.
    /// </summary>
    /// <param name="playerId">The ID of the player.</param>
    /// <returns>A list of player bio objects.</returns>
    public static async Task<IEnumerable<PlayerBioModel>> GetPlayerBio(string playerId)
    {
        var playerBioModel = new List<PlayerBioModel>();

        var response = await GetResponse("json/bios/" + playerId + ".json");
        var playerBioRootDto = JsonSerializer.Deserialize<PlayerBioRootDto>(response);

        playerBioModel.Add(new PlayerBioModel()
        {
            Id = playerBioRootDto?.Bio?.id,
            Type = playerBioRootDto?.Bio?.type,
            College = playerBioRootDto?.Bio?.college,
            DisplayName = playerBioRootDto?.Bio?.display_name,
            HighSchool = playerBioRootDto?.Bio?.highschool,
            OtherLabel = playerBioRootDto?.Bio?.other_label,
            OtherText = playerBioRootDto?.Bio?.other_text,
            Professional = playerBioRootDto?.Bio?.professional,
            Twitter = playerBioRootDto?.Bio?.twitter
        });

        return playerBioModel;
    }
}