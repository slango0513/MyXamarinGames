using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using Urho;
using Urho.Droid;

namespace MyUrhoGame.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : Activity
    {
        private MyGame myGame;
        private UrhoSurfacePlaceholder surface;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var layout = new FrameLayout(this);
            surface = UrhoSurface.CreateSurface(this);
            layout.AddView(surface);
            SetContentView(layout);
            myGame = await surface.Show<MyGame>(new ApplicationOptions("MyData"));
            //to stop the game use await surface.Stop().
        }

        protected override void OnResume()
        {
            UrhoSurface.OnResume();
            base.OnResume();
        }

        protected override void OnPause()
        {
            UrhoSurface.OnPause();
            base.OnPause();
        }

        public override void OnLowMemory()
        {
            UrhoSurface.OnLowMemory();
            base.OnLowMemory();
        }

        protected override void OnDestroy()
        {
            UrhoSurface.OnDestroy();
            base.OnDestroy();
        }

        public override bool DispatchKeyEvent(KeyEvent e)
        {
            if (e.KeyCode == Keycode.Back)
            {
                Finish();
                return false;
            }

            return base.DispatchKeyEvent(e);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            UrhoSurface.OnWindowFocusChanged(hasFocus);
            base.OnWindowFocusChanged(hasFocus);
        }
    }
}
