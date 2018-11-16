using ExchangeRates.Models;
using ExchangeRatesDomain.Models;

namespace ExchangeRates.Mappers
{
	public static class RatesRequestMapper
    {
		public static RatesInputModel MapToModel(this RatesRequest request)
		{
			return new RatesInputModel
			{
				BaseCurrency = request.BaseCurrency,
				TargetCurrency = request.TargetCurrency,
				Dates = request.Dates
			};
		}
	}
}
