using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.ResxConverter.Sample.Droid
{
    [Activity(Label = "Xamarin.ResxConverter.Sample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var textView = FindViewById<TextView>(Resource.Id.txtText);
            textView.Text = GetString(Resource.String.sample_string);
        }
    }
}

