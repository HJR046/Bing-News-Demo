
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NewsWayra.Droid
{
	[Activity(Label = "NewsResult")]
	public class NewsResult : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.NewsResults);

			var query = Intent.GetStringExtra("Query");
			Console.WriteLine(query);
			GetNews(query);
		}

		async void GetNews(string query) 
		{
			NewsManager newsManager = new NewsManager();
			var news = await newsManager.GetNews(query);
			ArrayAdapter adapter = new ArrayAdapter(this,
			                                        Resources.text, news);

			Console.WriteLine(news.ElementAt(0).Name);
		}

	
	}
}

