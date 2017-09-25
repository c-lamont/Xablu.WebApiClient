using Android.App;
using Android.Widget;
using Android.OS;
//using Xablu.WebApiClient;
//using Sample.Core;
using System;
//using Sample.Core.Models;
using Android.Views.Animations;
using System.Threading.Tasks;

namespace Sample.Droid
{
    [Activity(Label = "Sample.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Client.Initialize(() => new Xamarin.Android.Net.AndroidClientHandler());

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += async (sender, e) => await GetPosts();
        }

        private async Task GetPosts()
        {
            //var test = await Client.Getposts();
        }
    }
}

