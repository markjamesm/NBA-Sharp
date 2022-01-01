namespace NBASharp.ModelDto;

public class LeadTrackerRootDto
{
    public InternalDto _internal { get; set; }
    public List<PlayDto> plays { get; set; }
}