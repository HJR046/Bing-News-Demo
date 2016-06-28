using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace NewsWayra.iOS
{
    public partial class ResultsTableViewController : UITableViewController
    {

		public List<New> News
		{
			get;
			set;
		}

        public ResultsTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NewTableSource source = new NewTableSource(News);
			this.TableView.Source = source;
			TableView.ReloadData();
		}

    }
}