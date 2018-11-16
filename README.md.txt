Please do following steps:

1. Clone repository:
https://github.com/pstestrep/ExchangeRates.git

2. Build and run web.api project

3. To test API please download and run Postman from: https://www.getpostman.com/apps

- Put WebApi address in Postman window: http://localhost:50121/api/rates
- In 'Body' tab select 'Raw'
- Put below code to textBox:

{

	"baseCurrency": "SEK",

	"targetCurrency": "NOK",

	"dates": [
		"2018-03-01",
		"2018-02-15",
		"2018-02-01",
		"2017-03-12",
		"2018-07-01",
		"2010-12-21",
		"2011-11-09",
		"2009-10-07",
		"2001-09-04",
		"2007-08-19",
		"2015-06-02",
		"2013-03-17",
		"2012-02-15" 
	]

}