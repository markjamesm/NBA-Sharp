namespace NBASharp.Model;

public class BroadcastersModel
{
    public List<NationalModel> National { get; set; }
    public List<CanadianModel> Canadian { get; set; }
    public List<VTeamModel> VTeam { get; set; }
    public List<HTeamModel> HTeam { get; set; }
    public List<object> SpanishHTeam { get; set; }
    public List<object> SpanishVTeam { get; set; }
    public List<object> SpanishNational { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
}