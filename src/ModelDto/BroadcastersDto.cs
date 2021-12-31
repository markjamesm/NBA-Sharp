namespace NBASharp.ModelDto;

public class BroadcastersDto
{
    public List<NationalDto> national { get; set; }
    public List<CanadianDto> canadian { get; set; }
    public List<VTeamDto> vTeam { get; set; }
    public List<HTeamDto> hTeam { get; set; }
    public List<object> spanish_hTeam { get; set; }
    public List<object> spanish_vTeam { get; set; }
    public List<object> spanish_national { get; set; }
    public string shortName { get; set; }
    public string longName { get; set; }
}