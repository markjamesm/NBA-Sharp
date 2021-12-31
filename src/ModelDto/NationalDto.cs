namespace NBASharp.ModelDto;

public class NationalDto
{
    public string shortName { get; set; }
    public string longName { get; set; }
    public List<Stream> streams { get; set; }
    public List<object> broadcasters { get; set; }
}