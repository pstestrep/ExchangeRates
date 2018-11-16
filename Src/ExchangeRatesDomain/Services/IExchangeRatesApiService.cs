using ExchangeRatesDomain.Models;

namespace ExchangeRatesDomain.Services
{
	public interface IExchangeRatesApiService
    {
		HistoryModel GetHistoryByCurrency(string baseCurrency);
	}
}
