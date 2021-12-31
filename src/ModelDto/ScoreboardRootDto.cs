namespace NBASharp.ModelDto;

public class ScoreboardRootDto
{
    public InternalDto _internal { get; set; }
    public int numGames { get; set; }
    public List<GameDto> games { get; set; }
}