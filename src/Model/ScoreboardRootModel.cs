namespace NBASharp.Model;

public class ScoreboardRootModel
{
    public InternalModel Internal { get; set; }
    public int NumGames { get; set; }
    public List<GameModel> Games { get; set; }
}