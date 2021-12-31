namespace NBASharp.Model;

public class VideoModel
{
    public string BegionalBlackoutCodes { get; set; }
    public bool CanPurchase { get; set; }
    public bool IsLeaguePass { get; set; }
    public bool IsNationalBlackout { get; set; }
    public bool IsTNTOT { get; set; }
    public bool IsVR { get; set; }
    public bool TntotIsOnAir { get; set; }
    public bool IsNextVR { get; set; }
    public bool IsNBAOnTNTVR { get; set; }
    public bool IsMagicLeap { get; set; }
    public bool IsOculusVenues { get; set; }
    public List<Stream> streams { get; set; }
    public List<DeepLinkModel> deepLink { get; set; }
}