using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
           var button1 = FindViewById<Button>(Resource.Id.button1);
           var txt1 = FindViewById<TextView>(Resource.Id.textView1);
            button1.Click += delegate {
                txt1.Text="Hello world!";
            };
        }
    }
}

