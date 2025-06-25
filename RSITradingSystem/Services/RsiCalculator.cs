namespace RSITradingSystem.API.Services;

public class RsiCalculator
{
    public static decimal CalculateRsi(List<decimal> closes, int period = 14)
    {
        if (closes.Count < period + 1)
            return 0;

        decimal gain = 0;
        decimal loss = 0;

        for (int i = 1; i <= period; i++)
        {
            var change = closes[i] - closes[i - 1];
            if (change >= 0)
                gain += change;
            else
                loss -= change;
        }

        var avgGain = gain / period;
        var avgLoss = loss / period;

        if (avgLoss == 0) return 100;

        var rs = avgGain / avgLoss;
        var rsi = 100 - (100 / (1 + rs));

        return Math.Round(rsi, 2);
    }
}
