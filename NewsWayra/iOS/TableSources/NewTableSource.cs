using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
namespace NewsWayra.iOS
{
	public static class ImageExtensions
	{
		//https://github.com/HJR046/Emotion-Api-Xamarin-Demo/blob/master/iOSApp/Core.cs
		public static UIKit.UIImage ToImage(this byte[] data)
		{
			if (data == null)
			{
				return null;
			}

			UIKit.UIImage image;
			try
			{
				image = new UIKit.UIImage(Foundation.NSData.FromArray(data));
			}
			catch (Exception e)
			{
				return null;
			}

			return image;
		}

	}



	public class NewTableSource: UITableViewSource
	{
		List<New> news = new List<New>();

		public NewTableSource(List<New> news)
		{
			this.news = news;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{

			UITableViewCell cell = tableView.DequeueReusableCell("NewCell");
			New currentNew = news.ElementAt(indexPath.Row);

			var cellStyle = UITableViewCellStyle.Default;

			if (cell == null)
				cell = new UITableViewCell(cellStyle, "NewCell");

			cell.TextLabel.Lines = 2;
			cell.TextLabel.Font = UIFont.FromName("Helvetica", 12);
			cell.TextLabel.Text = currentNew.Name;

			if (cellStyle == UITableViewCellStyle.Default)
			{
				cell.ImageView.Image = currentNew.Image.ToImage();

			}
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return news.Count;
		}
	}
}

