using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.Android.Views
{
    [Activity(Label = "Tip Calculator", MainLauncher = true, Theme = "@style/AppTheme")]
    public class TipViewActivity : MvxActivity<TipViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.tip_vew);
        }
    }
}