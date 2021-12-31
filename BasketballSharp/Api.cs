namespace NBASharp;

/// <summary>
/// The Api class holds all MLB Stats API endpoints that can be accessed from Baseball Sharp.
/// </summary>
public static class Api
{
    private static readonly string _baseUrl = "https://data.nba.net/prod/v1";

    private static async Task<string> getResponse(string? endpoint)
    {
        using (var client = new HttpClient())
        {
            var return_message = new HttpResponseMessage();

            try
            {
                return_message = await client.GetAsync(_baseUrl + (endpoint ?? "")).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw;
            }

            return await return_message.Content.ReadAsStringAsync();
        }
    }
}