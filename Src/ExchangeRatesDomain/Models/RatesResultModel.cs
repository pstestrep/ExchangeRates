using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRatesDomain.Models
{
    public class RatesResultModel
    {
		public double MaxRate { get; set; }
		public string DateOfMaxRate { get; set; }

		public double MinRate { get; set; }
		public string DateOfMinRate { get; set; }

		public double AverageRate { get; set; }
	}
}
