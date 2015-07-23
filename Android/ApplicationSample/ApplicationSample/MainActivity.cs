using Android.App;
using Android.OS;
using Android.Widget;

namespace ApplicationSample
{
    [Activity(Label = "ApplicationSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            MyApplication myApplication = (MyApplication)this.Application;

            Button btnSet = FindViewById<Button>(Resource.Id.btnSet);
            Button btnChangeActivity = FindViewById<Button>(Resource.Id.btnChangeActivity);
            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);

            btnSet.Click += (sender, e) =>
            {
                myApplication.GValue1 = editText1.Text;
                Toast.MakeText(this, "設定了 GValue1", ToastLength.Long).Show();
            };

            btnChangeActivity.Click += (sender, e) =>
            {
                StartActivity(typeof(Activity2));
            };
        }
    }
}

