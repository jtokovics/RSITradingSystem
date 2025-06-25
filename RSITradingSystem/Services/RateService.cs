using Microsoft.Extensions.Options;
using RSITradingSystem.API.Models;

namespace RSITradingSystem.API.Services;

public class RateService
{
    private readonly FinnhubOptions _options;

    public RateService(IOptions<FinnhubOptions> options)
    {
        _options = options.Value;
    }

    //public RateResult GetRate(string symbol)
    //{
    //    var ask = Math.Round(100 + (decimal)(random.NextDouble() * 10), 4);
    //    var bid = ask - 0.02m;

    //    // Dummy záróárak RSI-hez
    //    var closes = Enumerable.Range(0, 15)
    //        .Select(_ => ask + (decimal)(random.NextDouble() - 0.5))
    //        .ToList();

    //    var rsi = RsiCalculator.CalculateRsi(closes);

    //    return new RateResult
    //    {
    //        Symbol = symbol,
    //        Ask = ask,
    //        Bid = bid,
    //        Rsi = rsi,
    //        DailyChangePercent = Math.Round((ask - 100) / 100 * 100, 2)
    //    };
    //}
}
