using ExchangeRatesDomain.Models;
using System;
using System.Collections.Generic;

namespace ExchangeRatesDomain.Services
{
	public class ExchangeRatesService : IExchangeRatesService
	{
		//simple "cache" for rates
		private Dictionary<string, HistoryModel> _rates;

		private readonly IExchangeRatesApiService _exchangeRateApiService;

		public ExchangeRatesService(IExchangeRatesApiService exchangeRateApiService)
		{
			_rates = new Dictionary<string, HistoryModel>();

			_exchangeRateApiService = exchangeRateApiService;
		}

		public RatesResultModel FilterAndCompute(RatesInputModel input)
		{
			var result = new RatesResultModel
			{
				MaxRate = (double)0,
				MinRate = Double.MaxValue
			};

			GetHistoryByCurrency(input.BaseCurrency);

			double ratesSum = 0;
			int existingDates = 0;

			foreach (var date in input.Dates)
			{
				if (!_rates.ContainsKey(input.BaseCurrency))
					continue;

				if (_rates[input.BaseCurrency].Rates.TryGetValue(date, out var currencies))
				{
					existingDates++;

					if (currencies.ContainsKey(input.TargetCurrency))
					{
						if (currencies.TryGetValue(input.TargetCurrency, out var rate))
						{
							if (result.MaxRate < rate)
							{
								result.MaxRate = rate;
								result.DateOfMaxRate = date;
							}

							if (result.MinRate > rate)
							{
								result.MinRate = rate;
								result.DateOfMinRate = date;
							}

							ratesSum += rate;
						}
					}
				}
			}

			if (existingDates > 0)
				result.AverageRate = ratesSum / existingDates;

			return result;
		}

		private void GetHistoryByCurrency(string baseCurrency)
		{
			if (!_rates.ContainsKey(baseCurrency))
			{
				var history = _exchangeRateApiService.GetHistoryByCurrency(baseCurrency);

				if (history == null)
					throw new InvalidOperationException("Bad call to exchange rates Api.");

				_rates.Add(baseCurrency, history);
			}
		}
	}
}
