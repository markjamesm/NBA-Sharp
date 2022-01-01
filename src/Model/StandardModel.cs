using NBASharp.ModelDto;

namespace NBASharp.Model;

public class StandardModel
{
    public string TeamId { get; set; }
    public List<PlayerModel> Players { get; set; }
}