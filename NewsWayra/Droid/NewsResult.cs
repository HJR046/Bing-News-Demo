
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
		ListView lvResults;
		List<New> news;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.NewsResults);
			lvResults = FindViewById<ListView>(Resource.Id.lvResults);
			lvResults.ItemClick += (send, args) =>
			{
				int position = args.Position;
				navigate(position);
			};
			var query = Intent.GetStringExtra("Query");
			Console.WriteLine(query);
			GetNews(query);

		}
		async void GetNews(string query) 
		{
			NewsManager newsManager = new NewsManager();
			 news = await newsManager.GetNews(query);
			NewsAdapter adapter = new NewsAdapter(news, this);

			 
			lvResults.Adapter = adapter;

		}
		void navigate(int position)
		{
			New selectedNew = news.ElementAt(position);
			//Navegar
		}

	
	}
}

