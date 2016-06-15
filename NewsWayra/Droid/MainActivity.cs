using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace NewsWayra.Droid
{
	[Activity(Label = "NewsWayra", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.btnSearch);
			EditText edtQuery = FindViewById<EditText>(Resource.Id.edtQuery);

			button.Click += delegate {
				Intent resultsIntent = new Intent(this, typeof(NewsResult));
				resultsIntent.PutExtra("Query", edtQuery.Text);
				StartActivity(resultsIntent);
			};
		}
	}
}


