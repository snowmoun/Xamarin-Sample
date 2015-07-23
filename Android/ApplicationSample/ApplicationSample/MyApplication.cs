using Android.App;
using Android.Runtime;
using System;

namespace ApplicationSample
{
    [Application]
    public class MyApplication : Application
    {
        public string GValue1 { get; set; }

        public MyApplication(IntPtr javaReference, JniHandleOwnership transfer)
            :base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
        }
    }
}