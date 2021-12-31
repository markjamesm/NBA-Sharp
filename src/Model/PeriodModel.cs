namespace NBASharp.Model;

public class PeriodModel
{
    public int Type { get; set; }
    public int MaxRegular { get; set; }
    public bool IsHalftime { get; set; }
    public bool IsEndOfPeriod { get; set; }
}