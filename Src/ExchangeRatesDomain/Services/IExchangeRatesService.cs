using ExchangeRatesDomain.Models;

namespace ExchangeRatesDomain.Services
{
	public interface IExchangeRatesService
    {
		RatesResultModel FilterAndCompute(RatesInputModel input);
	}
}
