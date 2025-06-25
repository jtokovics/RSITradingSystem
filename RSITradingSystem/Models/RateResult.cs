namespace RSITradingSystem.API.Models;

public class RateResult
{
    public string Symbol { get; set; } = "";
    public decimal Ask { get; set; }
    public decimal Bid { get; set; }
    public decimal Rsi { get; set; }
    public decimal DailyChangePercent { get; set; }
}
