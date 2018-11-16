namespace ExchangeRates.Models
{
	public class RatesRequest
    {
		public string[] Dates { get; set; }
		public string BaseCurrency { get; set; }
		public string TargetCurrency { get; set; }
	}
}
