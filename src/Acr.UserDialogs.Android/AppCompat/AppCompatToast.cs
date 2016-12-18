using System;


namespace Acr.UserDialogs.AppCompat
{
    public class AppCompatToast : IDisposable
    {
        readonly Activity activity;
        readonly ToastConfig config;
        Snackbar snackBar;


        public AppCompatToast(Activity activity, ToastConfig config)
        {
            this.activity = activity;
            this.config = config;
        }


        public void Show()
        {
            this.activity.RunOnUiThread(() =>
            {
                var view = activity.Window.DecorView.RootView.FindViewById(Android.Resource.Id.Content);
                this.snackBar = this.snackBar.Make(
                    view,
                    Html.FromHtml(this.config.Message),
                    (int)this.config.Duration.TotalMilliseconds
                );
                this.TrySetToastTextColor();
                if (this.config.BackgroundColor != null)
                    this.snackBar.View.SetBackgroundColor(this.config.BackgroundColor.Value.ToNative());

                if (this.config.Action != null)
                {
                    this.snackBar.SetAction(this.config.Action.Text, x =>
                    {
                        this.config.Action?.Action?.Invoke();
                        this.snackBar.Dismiss();
                    });
                    var color = this.config.Action.TextColor ?? ToastConfig.DefaultActionTextColor;
                    if (color != null)
                        this.snackBar.SetActionTextColor(color.Value.ToNative());
                }
                this.snackBar.Show();
            });
        }


        protected virtual void TrySetToastTextColor()
        {
            var textColor = this.config.MessageTextColor ?? ToastConfig.DefaultMessageTextColor;
            if (textColor == null)
                return;

            var viewGroup = this.snackBar.View as ViewGroup;
            if (viewGroup != null)
            {
                for (var i = 0; i < viewGroup.ChildCount; i++)
                {
                    var child = viewGroup.GetChildAt(i);
                    var textView = child as TextView;
                    if (textView != null)
                    {
                        textView.SetTextColor(textColor.Value.ToNative());
                        break;
                    }
                }
            }
        }


        public void Dispose()
        {
            if (!this.snackBar.IsShown)
                return;

            this.activity.RunOnUiThread(() =>
            {
                try
                {
                    this.snackBar.Dismiss();
                }
                catch
                {
                    // catch and swallow
                }
            });
        }
    }
}