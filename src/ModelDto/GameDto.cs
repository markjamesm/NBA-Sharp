namespace NBASharp.ModelDto;

public class GameDto
{
    public int seasonStageId { get; set; }
    public string seasonYear { get; set; }
    public string gameId { get; set; }
    public ArenaDto arena { get; set; }
    public bool isGameActivated { get; set; }
    public int statusNum { get; set; }
    public int extendedStatusNum { get; set; }
    public string startTimeEastern { get; set; }
    public DateTime startTimeUTC { get; set; }
    public DateTime endTimeUTC { get; set; }
    public string startDateEastern { get; set; }
    public string clock { get; set; }
    public bool isBuzzerBeater { get; set; }
    public bool isPreviewArticleAvail { get; set; }
    public bool isRecapArticleAvail { get; set; }
    public TicketsDto tickets { get; set; }
    public bool hasGameBookPdf { get; set; }
    public bool isStartTimeTBD { get; set; }
    public NuggetDto nugget { get; set; }
    public string attendance { get; set; }
    public GameDurationDto gameDuration { get; set; }
    public PeriodDto period { get; set; }
    public VTeamDto vTeam { get; set; }
    public HTeamDto hTeam { get; set; }
    public WatchDto watch { get; set; }
}