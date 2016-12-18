using System;


namespace Acr.UserDialogs.Clasic
{
    public class ClassicAlertDialog : IAlertDialog
    {

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