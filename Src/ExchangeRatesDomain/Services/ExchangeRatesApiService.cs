using ExchangeRatesDomain.Extensions;
using ExchangeRatesDomain.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ExchangeRatesDomain.Services
{
	public class ExchangeRatesApiService : IExchangeRatesApiService
	{
		private const string _baseUrl = "https://api.exchangeratesapi.io";

		public HistoryModel GetHistoryByCurrency(string baseCurrency)
		{
			var result = new HistoryModel();

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(_baseUrl);
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				var endDate = DateTime.Today.ToString("yyyy-MM-dd");
				var response = client.GetAsync($"history?start_at=1999-01-01&end_at={endDate}&base={baseCurrency}").Result;

				if (!response.IsSuccessStatusCode)
					return null;

					string responseString = response.Content.ReadAsStringAsync().Result;
					result = response.Content.ReadAsAsync<HistoryModel>().Result;
			}

			return result;
		}
    }
}
