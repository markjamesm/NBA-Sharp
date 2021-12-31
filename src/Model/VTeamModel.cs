namespace NBASharp.Model;

public class VTeamModel
{
    public string TeamId { get; set; }
    public string TriCode { get; set; }
    public string Win { get; set; }
    public string Loss { get; set; }
    public string SeriesWin { get; set; }
    public string SeriesLoss { get; set; }
    public string Score { get; set; }
    public List<LinescoreModel> linescore { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public List<Stream> Streams { get; set; }
    public List<Broa> broadcasters { get; set; }
}