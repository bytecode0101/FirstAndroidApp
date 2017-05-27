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

namespace App1
{
    [Activity(Label = "Result")]
    public class ResultActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Result);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var btnExit = FindViewById<Button>(Resource.Id.btnExit);
            btnNext.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            btnExit.Click += delegate
            {
                System.Environment.Exit(0);
            };
        }
    }
}