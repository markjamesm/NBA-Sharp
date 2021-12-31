namespace NBASharp.ModelDto;

public class PeriodDto
{
    public int current { get; set; }
    public int type { get; set; }
    public int maxRegular { get; set; }
    public bool isHalftime { get; set; }
    public bool isEndOfPeriod { get; set; }
}