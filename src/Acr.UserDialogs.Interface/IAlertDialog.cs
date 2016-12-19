using System;
using System.Collections.Generic;


namespace Acr.UserDialogs
{
    public interface IAlertDialog : IDisposable
    {
        string Message { get; set; }
        string Title { get; set; }
        bool IsCancellable { get; set; }

        IDialogAction Positive { get; set; }
        IDialogAction Neutral { get; set; }
        IDialogAction Negative { get; set; }

        IReadOnlyList<IDialogAction> Actions { get; }
        IReadOnlyList<ITextEntry> TextEntries { get; }

        IAlertDialog Add(ITextEntry instance);
        IAlertDialog Add(IDialogAction action);

        void Show();
        void Dismiss();

        // TODO: what about outside cancel?
        Action<IDialogAction> Dismissed { get; set; }
    }
}
