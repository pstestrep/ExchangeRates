using ExchangeRates.Mappers;
using ExchangeRates.Models;
using ExchangeRatesDomain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeRates.Controllers
{
	[Route("api/rates")]
    public class RatesController : Controller
    {
		private readonly IExchangeRatesService _exchangeRateService;

		public RatesController(IExchangeRatesService exchangeRateService)
		{
			_exchangeRateService = exchangeRateService;
		}

        [HttpGet]
        public IActionResult Get([FromBody]RatesRequest request)
        {
			var resultModel = _exchangeRateService.FilterAndCompute(RatesRequestMapper.MapToModel(request));

			return Ok(RatesResponseMapper.MapToResponse(resultModel));
        }
    }
}
