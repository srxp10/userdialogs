using System;
using System.Collections.Generic;


namespace Acr.UserDialogs
{
    public interface IAlertDialog
    {
        string Message { get; set; }
        string Title { get; set; }
        bool IsCancellable { get; set; }

        IAction Positive { get; }
        IAction Neutral { get; }
        IAction Negative { get; }

        IReadOnlyList<IAction> Actions { get; }
        IReadOnlyList<ITextEntry> TextEntries { get; }

        IAlertDialog AddTextBox(Action<ITextEntry> instance);
        IAlertDialog AddAction(Action<IAction> action);
        IAlertDialog SetMainAction(DialogChoice choice, Action<IAction> action);
        void Show();
        void Dismiss();

        Action Dismissed { get; set; }
    }
}
