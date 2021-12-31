namespace NBASharp.Model;

public class StreamModel
{
    public string StreamType { get; set; }
    public bool IsOnAir { get; set; }
    public bool DoesArchiveExist { get; set; }
    public bool IsArchiveAvailToWatch { get; set; }
    public string StreamId { get; set; }
    public int Duration { get; set; }
    public string Language { get; set; }
}