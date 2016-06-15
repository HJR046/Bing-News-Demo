using System;
using System.Threading.Tasks;
using NewsAppDemo;
using System.Linq;
using System.Collections.Generic;

namespace NewsWayra
{
	public class NewsManager
	{
		public NewsManager()
		{
		}


		private const int numberOfResults = 20;

		public async Task<List<New>> GetNews(string query) 
		{
			BingNewClient newsClient = new BingNewClient();
			var newsJson = await newsClient.GetNews(query, numberOfResults);
			var parsedNews = Newtonsoft.Json.JsonConvert.DeserializeObject<NewsResult>(newsJson);

			var news = (from newItem in parsedNews.value
			            select new New(newItem.name, newItem.url, newItem.image?.thumbnail?.contentUrl,
			                           newItem.datePublished, newItem.category)).ToList();

			return news;
		}

	}
}

