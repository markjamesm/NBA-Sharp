namespace NBASharp.Model;

public class NationalModel
{
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public List<Stream> Streams { get; set; }
    public List<object> Broadcasters { get; set; }
}