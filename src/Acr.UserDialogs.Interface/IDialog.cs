using System;
using System.Collections.Generic;


namespace Acr.UserDialogs
{
    public interface IAlertDialog
    {
        string Message { get; set; }
        string Title { get; set; }
        bool IsCancellable { get; set; }

        IAction Positive { get; set; }
        IAction Neutral { get; set; }
        IAction Negative { get; set; }

        IList<IAction> Actions { get; }
        IList<ITextEntry> TextEntries { get; }

        IAlertDialog AddTextBox(Action<ITextEntry> instance);
        IAlertDialog AddAction(Action<IAction> button);
        void Show();
        void Dismiss();

        //Action Dismissed { get; set; }
    }
}
