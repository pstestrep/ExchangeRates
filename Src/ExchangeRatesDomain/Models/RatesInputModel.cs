namespace ExchangeRatesDomain.Models
{
	public class RatesInputModel
    {
		public string[] Dates { get; set; }
		public string BaseCurrency { get; set; }
		public string TargetCurrency { get; set; }
	}
}
