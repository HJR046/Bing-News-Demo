using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace NewsWayra.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		string query;
		List<New> news;
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.

			btnSearch.TouchUpInside += async (sender,args)=>
			{
				NewsManager newsManager = new NewsManager();
				query = txfQuery.Text;
			 news = await newsManager.GetNews(query);
				PerformSegue("NewsResultsSegue",(NSObject) sender);
			};
		}


		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			var resultsController = segue.DestinationViewController as ResultsTableViewController;

			if (resultsController != null)
			{
				resultsController.News = news;
			}

		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
