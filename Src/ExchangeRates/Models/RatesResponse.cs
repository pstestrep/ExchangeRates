namespace ExchangeRates.Models
{
	public class RatesResponse
    {
		public double MaxRate { get; set; }
		public string DateOfMaxRate { get; set; }

		public double MinRate { get; set; }
		public string DateOfMinRate { get; set; }

		public double AverageRate { get; set; }
    }
}
