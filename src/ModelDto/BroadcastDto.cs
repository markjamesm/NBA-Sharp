namespace NBASharp.ModelDto;

public class BroadcastDto
{
    public BroadcastersDto broadcasters { get; set; }
    public VideoDto video { get; set; }
    public AudioDto audio { get; set; }
}