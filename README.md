# 📈 RSITradingSystem

A multithreaded trading and analysis system built with .NET 8, PostgreSQL, and Docker. It fetches real-time market data and calculates the Relative Strength Index (RSI) to power a basic algorithmic trading bot.

---

## ⚙️ Features

- Periodic (1-min) quote fetching from [Finnhub.io](https://finnhub.io/)
- RSI calculation from OHLC candlestick data
- Daily percentage price movement
- Multi-currency support: `XAUUSD`, `US500USD`, `EURUSD`, `EURHUF`, `USDHUF`
- Modular architecture: data fetcher, analytics engine, and trading logic
- Logging with full audit trail (debug/info/warn/error levels)
- React-based UI (planned): enable/disable trading, manage long/short switches

---

## 🧱 Tech Stack

| Component     | Technology            |
|---------------|-----------------------|
| Backend       | ASP.NET Core (.NET 8) |
| Database      | PostgreSQL (Docker)   |
| Frontend      | React (planned)       |
| Data Provider | Finnhub API           |
| DevOps        | Docker, Git           |

---

## 🚀 Getting Started

```bash
git clone https://github.com/jtokovics/RSITradingSystem.git
cd RSITradingSystem
