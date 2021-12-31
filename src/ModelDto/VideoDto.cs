namespace NBASharp.ModelDto;

public class VideoDto
{
    public string regionalBlackoutCodes { get; set; }
    public bool canPurchase { get; set; }
    public bool isLeaguePass { get; set; }
    public bool isNationalBlackout { get; set; }
    public bool isTNTOT { get; set; }
    public bool isVR { get; set; }
    public bool tntotIsOnAir { get; set; }
    public bool isNextVR { get; set; }
    public bool isNBAOnTNTVR { get; set; }
    public bool isMagicLeap { get; set; }
    public bool isOculusVenues { get; set; }
    public List<Stream> streams { get; set; }
    public List<DeepLinkDto> deepLink { get; set; }
}