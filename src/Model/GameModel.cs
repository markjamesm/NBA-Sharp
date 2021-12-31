namespace NBASharp.Model;

public class GameModel
{
    public int? SeasonStageId { get; set; }
    public string SeasonYear { get; set; }
    public string GameId { get; set; }
    public ArenaModel? Arena { get; set; }
    public bool? IsGameActivated { get; set; }
    public int? StatusNum { get; set; }
    public int? ExtendedStatusNum { get; set; }
    public string StartTimeEastern { get; set; }
    public DateTime? StartTimeUTC { get; set; }
    public DateTime? EndTimeUTC { get; set; }
    public string StartDateEastern { get; set; }
    public string Clock { get; set; }
    public bool? IsBuzzerBeater { get; set; }
    public bool? IsPreviewArticleAvail { get; set; }
    public bool? IsRecapArticleAvail { get; set; }
    public TicketsModel? Tickets { get; set; }
    public bool? HasGameBookPdf { get; set; }
    public bool? IsStartTimeTBD { get; set; }
    public NuggetModel? Nugget { get; set; }
    public string? Attendance { get; set; }
    public GameDurationModel? GameDuration { get; set; }
    public PeriodModel? Period { get; set; }
    public VTeamModel? VTeam { get; set; }
    public HTeamModel? HTeam { get; set; }
    public WatchModel? Watch { get; set; }
}