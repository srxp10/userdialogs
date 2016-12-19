using System;
using Android.App;


namespace Acr.UserDialogs.Internals
{
    public abstract class AbstractDroidAlertDialog : AbstractAlertDialog
    {
        protected AbstractDroidAlertDialog(Activity activity)
        {
            this.Activity = activity;
        }


        protected Activity Activity { get; }


        protected override IDialogAction CreateAction()
        {
            return new ActionImpl();
        }


        protected override ITextEntry CreateTextEntry()
        {
            return new TextEntryImpl(this.Activity);
        }
    }
}