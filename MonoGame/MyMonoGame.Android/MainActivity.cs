using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Microsoft.Xna.Framework;

namespace MyMonoGame.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
        ScreenOrientation = ScreenOrientation.Landscape
        //LaunchMode = LaunchMode.SingleInstance,
        //AlwaysRetainTaskState = true,
        //ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize
        )]
    public class MainActivity : AndroidGameActivity
    {
        private Game1 game;
        private View view;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            game = new Game1();
            //view = game.Services.GetService(typeof(View)) as View;
            view = game.Services.GetService<View>();

            SetContentView(view);
            game.Run();
        }
    }
}
