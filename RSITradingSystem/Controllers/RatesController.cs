using Microsoft.AspNetCore.Mvc;
using RSITradingSystem.API.Services;

namespace RSITradingSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RatesController : ControllerBase
{
    private readonly RateService _rateService = new();

    [HttpGet("{symbol}")]
    public IActionResult GetRate(string symbol)
    {
        var result = _rateService.GetRate(symbol.ToUpper());
        return Ok(result);
    }
}
