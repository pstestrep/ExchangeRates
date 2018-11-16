using ExchangeRates.Models;
using ExchangeRatesDomain.Models;

namespace ExchangeRates.Mappers
{
	public static class RatesResponseMapper
    {
		public static RatesResponse MapToResponse(this RatesResultModel resultModel)
		{
			return new RatesResponse
			{
				AverageRate = resultModel.AverageRate,
				DateOfMaxRate = resultModel.DateOfMaxRate,
				DateOfMinRate = resultModel.DateOfMinRate,
				MaxRate = resultModel.MaxRate,
				MinRate = resultModel.MinRate
			};
		}
	}
}
