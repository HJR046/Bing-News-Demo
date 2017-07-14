using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace NewsWayra
{
	public class BingNewClient
	{

		private readonly HttpClient _newsClient = new HttpClient();
		private const string url = 
			"https://api.cognitive.microsoft.com/bing/v5.0/news/search?q={0}&count={1}&offset={2}&mkt={3}&safeSearch={4}";

		public BingNewClient()
		{
		}

		public async Task<string> GetNews(string query, int numberOfResults) {
			string response = string.Empty;

			var queryString = new Dictionary<string, string>();

			queryString.Add("query",query);
			queryString.Add("count", numberOfResults.ToString());
			queryString.Add("offset", "0");
			queryString.Add("mkt", "es-mx");
			queryString.Add("safeSearch", "Moderate");

			var requestUrl = string.Format(url, queryString["query"], queryString["count"], queryString["offset"]
										   , queryString["mkt"], queryString["safeSearch"]);

			_newsClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "YourKey");
			response = await _newsClient.GetStringAsync(requestUrl);

			return response;
		}



	}
}

