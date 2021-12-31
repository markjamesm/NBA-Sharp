namespace NBASharp.Model;

public class HTeamModel
{
    public string TeamId { get; set; }
    public string Win { get; set; }
    public string Loss { get; set; }
    public string SeriesWin { get; set; }
    public string SeriesLoss { get; set; }
    public string Score { get; set; }
    public List<LinescoreModel> Linescore { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public List<Stream> Streams { get; set; }
    public List<BroadcastersModel> Broadcasters { get; set; }
}