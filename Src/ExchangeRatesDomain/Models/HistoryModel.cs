using System.Collections.Generic;

namespace ExchangeRatesDomain.Models
{
	public class HistoryModel
    {
		public string Base { get; set; }
		public string Start_at { get; set; }
		public string End_at { get; set; }
		public Dictionary<string, Dictionary<string, double>> Rates { get; set; }
    }
}
