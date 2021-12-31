namespace NBASharp.ModelDto;

public class HTeamDto
{
    public string teamId { get; set; }
    public string triCode { get; set; }
    public string win { get; set; }
    public string loss { get; set; }
    public string seriesWin { get; set; }
    public string seriesLoss { get; set; }
    public string score { get; set; }
    public List<LinescoreDto> linescore { get; set; }
    public string shortName { get; set; }
    public string longName { get; set; }
    public List<Stream> streams { get; set; }
    public List<BroadcastersDto> broadcasters { get; set; }
}