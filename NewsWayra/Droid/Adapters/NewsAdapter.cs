using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using System.Linq;
using Android.Graphics;

namespace NewsWayra.Droid
{
	public class NewsAdapter :BaseAdapter
	{
		List<New> news;
		Activity context;
		public NewsAdapter(List<New> news, Activity context)
		{
			this.news = news;
			this.context = context;
		}

		public override int Count
		{
			get
			{
				return news.Count;
			}
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null; //news.ElementAt(position) as Java.Lang.Object;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate
											 (Resource.Layout.CustomNewCell, parent, false);
			var txtNewTitle = view.FindViewById<TextView>(Resource.Id.txtNewTitle);
			var imgNewImage = view.FindViewById<ImageView>(Resource.Id.imNewImage);


			New currentNew = news.ElementAt(position);
			txtNewTitle.Text = currentNew.Name;

			if (currentNew.Image == null)
			{
				imgNewImage.SetImageResource(Resource.Mipmap.Icon);
													//Drawable para Visual Studio
			}
			else 
			{
				Bitmap newBitmap = BitmapFactory.DecodeByteArray(currentNew.Image, 0, 
				                                                 currentNew.Image.Length);
				imgNewImage.SetImageBitmap(newBitmap);
			}

			return view;
		}
	}
}

