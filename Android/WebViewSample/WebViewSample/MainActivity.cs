using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace WebViewSample
{
    [Activity(Label = "棟哥的部落格", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        WebView webView;
        string webViewURL = "http://www.adminote.com";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            webView = FindViewById<WebView>(Resource.Id.webView);

            webView.Settings.JavaScriptEnabled = true;

            webView.LoadUrl(webViewURL);

            webView.SetWebViewClient(new CustWebViewClient());
        }
    }


    /// <summary>
    /// 巢狀Class 繼承WebViewClient
    /// </summary>
    public class CustWebViewClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }

    }
}

