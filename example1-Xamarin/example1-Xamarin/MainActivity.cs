using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Media;
using System;
using Android.Views;

namespace example1_Xamarin
{
    [Activity(Label = "example1_Xamarin", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btn_button1;
        private Button btn_button2;
        private Button btn_button3;
        private Button btn_button4;
        private LinearLayout lyt_middle;
        private ImageButton btn_mccree;
        private ImageButton btn_zenyatta;
        private ImageButton btn_soldier76;
        private ImageButton btn_genji;
        private ImageButton btn_reinhardt;
        private ImageButton btn_rubberduck;
        private ImageButton btn_pachimari;
        private ImageButton btn_pingu;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btn_button1 = FindViewById<Button>(Resource.Id.btn_button1);
            btn_button2 = FindViewById<Button>(Resource.Id.btn_button2);
            btn_button3 = FindViewById<Button>(Resource.Id.btn_button3);
            btn_button4 = FindViewById<Button>(Resource.Id.btn_button4);

            lyt_middle = FindViewById<LinearLayout>(Resource.Id.lyt_middle);

            btn_mccree = FindViewById<ImageButton>(Resource.Id.btn_mccree);
            btn_zenyatta = FindViewById<ImageButton>(Resource.Id.btn_zenyatta);
            btn_soldier76 = FindViewById<ImageButton>(Resource.Id.btn_soldier76);
            btn_genji = FindViewById<ImageButton>(Resource.Id.btn_genji);
            btn_reinhardt = FindViewById<ImageButton>(Resource.Id.btn_reinhardt);
            btn_rubberduck = FindViewById<ImageButton>(Resource.Id.btn_rubberduck);
            btn_pachimari = FindViewById<ImageButton>(Resource.Id.btn_pachimari);
            btn_pingu = FindViewById<ImageButton>(Resource.Id.btn_pingu);
            
            btn_button1.Click += OnAlertClick;
            btn_button2.Click += OnToggleClick;
            btn_button3.Click += OnShowClick;
            btn_button4.Click += OnCloseClick;

            btn_mccree.Click += OnMcCreeClick;
            btn_zenyatta.Click += OnZenyattaClick;
            btn_soldier76.Click += OnSoldier76Click;
            btn_genji.Click += OnGenjiClick;
            btn_reinhardt.Click += OnReinhardtClick;
            btn_rubberduck.Click += OnRubberduckClick;
            btn_pachimari.Click += OnPachimariClick;
            btn_pingu.Click += OnPinguClick;
        }

        private void OnMcCreeClick(object sender, EventArgs e)
        {
            MediaPlayer mccree = MediaPlayer.Create(this, Resource.Raw.mccree);
            mccree.Start();
        }

        private void OnZenyattaClick(object sender, EventArgs e)
        {
            MediaPlayer zenyatta = MediaPlayer.Create(this, Resource.Raw.zenyatta);
            zenyatta.Start();
        }

        private void OnSoldier76Click(object sender, EventArgs e)
        {
            MediaPlayer soldier76 = MediaPlayer.Create(this, Resource.Raw.s76);
            soldier76.Start();
        }

        private void OnGenjiClick(object sender, EventArgs e)
        {
            MediaPlayer genji = MediaPlayer.Create(this, Resource.Raw.madamada);
            genji.Start();
        }

        private void OnReinhardtClick(object sender, EventArgs e)
        {
            MediaPlayer reinhardt = MediaPlayer.Create(this, Resource.Raw.reinhardt);
            reinhardt.Start();
        }

        private void OnRubberduckClick(object sender, EventArgs e)
        {
            MediaPlayer rubberduck = MediaPlayer.Create(this, Resource.Raw.duck);
            rubberduck.Start();
        }

        private void OnPachimariClick(object sender, EventArgs e)
        {
            MediaPlayer pachimari = MediaPlayer.Create(this, Resource.Raw.pachimari);
            pachimari.Start();
        }

        private void OnPinguClick(object sender, EventArgs e)
        {
            MediaPlayer pingu = MediaPlayer.Create(this, Resource.Raw.pingu);
            pingu.Start();
        }

        private void OnAlertClick(object sender, EventArgs e)
        {
            Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
            alert.SetTitle("Alert");
            alert.SetMessage("I know what you did last summer");
            alert.SetPositiveButton("OH NO!", (senderAlert, args) => {
            });

            Dialog dialog = alert.Create();
            dialog.Show();

        }

        private void OnToggleClick(object sender, EventArgs e)
        {
            if (lyt_middle.Visibility == ViewStates.Visible)
            {
                lyt_middle.Visibility = ViewStates.Gone;
            }
            else
            {
                lyt_middle.Visibility = ViewStates.Visible;
            }
        }

        private void OnShowClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Manual breathing ACTIVATED!", ToastLength.Short).Show();
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}

