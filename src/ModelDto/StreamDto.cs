namespace NBASharp.ModelDto;

public class StreamDto
{
    public string streamType { get; set; }
    public bool isOnAir { get; set; }
    public bool doesArchiveExist { get; set; }
    public bool isArchiveAvailToWatch { get; set; }
    public string streamId { get; set; }
    public int duration { get; set; }
    public string language { get; set; }
}