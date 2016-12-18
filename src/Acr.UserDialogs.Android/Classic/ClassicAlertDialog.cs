using System;
using Acr.UserDialogs.Internals;
using Android.App;


namespace Acr.UserDialogs.Classic
{
    public class ClassicAlertDialog : AbstractDroidAlertDialog
    {
        AlertDialog.Builder builder;


        public ClassicAlertDialog(Activity activity) : base(activity)
        {
        }


        public override void Show()
        {
            this.builder = new AlertDialog.Builder(this.Activity);
        }


        public override void Dismiss()
        {
        }


        protected virtual IDisposable Show(Activity activity, Func<Dialog> dialogBuilder)
        {
            Dialog dialog = null;
            activity.RunOnUiThread(() =>
            {
                dialog = dialogBuilder();
                dialog.Show();
            });
            return new DisposableAction(() =>
                activity.RunOnUiThread(dialog.Dismiss)
            );
        }
    }
}