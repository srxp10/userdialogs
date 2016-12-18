using System;
using Android.App;
using AndroidHUD;


namespace Acr.UserDialogs.Classic
{
    public class ClassicToast : IDisposable
    {
        readonly Activity activity;
        readonly ToastConfig config;


        public ClassicToast(Activity activity, ToastConfig config)
        {
            this.activity = activity;
            this.config = config;
        }


        public void Show()
        {
            AndHUD.Shared.ShowToast(
                this.activity,
                this.config.Message,
                AndroidHUD.MaskType.None,
                this.config.Duration,
                false,
                () =>
                {
                    AndHUD.Shared.Dismiss();
                    this.config.Action?.Action?.Invoke();
                }
            );
        }


        public void Dispose()
        {
            try
            {
                AndHUD.Shared.Dismiss(this.activity);
            }
            catch
            {
            }
        }
    }
}