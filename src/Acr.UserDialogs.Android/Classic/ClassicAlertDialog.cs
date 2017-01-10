using System;
using Android.App;
using Android.Widget;


namespace Acr.UserDialogs.Classic
{
    public class ClassicAlertDialog : AbstractAlertDialog
    {
        readonly Activity activity;
        readonly IEditTextBuilder editTextBuilder;
        AlertDialog.Builder builder;
        AlertDialog dialog;


        public ClassicAlertDialog(Activity activity, IEditTextBuilder editTextBuilder)
        {
            this.activity = activity;
            this.editTextBuilder = editTextBuilder;
        }


        public override void Show()
        {
            // TODO: everything below here has to happen on the main thread
            this.activity.RunOnUiThread(() =>
            {
                this.builder = new AlertDialog.Builder(this.activity);
                //        dialog = dialogBuilder();
                //        dialog.Show();
            });

        }


        public override void Dismiss()
        {
            this.activity.RunOnUiThread(this.dialog.Dismiss);
        }


        protected virtual EditText Create(TextEntry text)
        {
            return null;
        }


        protected virtual void Create(DialogAction action)
        {

        }
    }
}