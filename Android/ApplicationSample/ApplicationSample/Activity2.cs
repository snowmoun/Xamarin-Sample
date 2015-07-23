using Android.App;
using Android.OS;
using Android.Widget;

namespace ApplicationSample
{
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Activity2);

            TextView tv = FindViewById<TextView>(Resource.Id.tvGetGValue1);
            tv.Text = (this.Application as MyApplication).GValue1;
        }
    }
}