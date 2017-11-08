using Android.App;
using Android.Widget;
using Android.OS;

namespace example1_Xamarin
{
    [Activity(Label = "example1_Xamarin", MainLauncher = true)]
    public class MainActivity : app
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

