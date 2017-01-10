using System;
using System.Collections.Generic;


namespace Acr.UserDialogs
{
    public interface IAlertDialog : IDisposable
    {
        string Message { get; set; }
        string Title { get; set; }
        bool IsCancellable { get; set; }


        DialogAction Positive { get; set; }
        DialogAction Neutral { get; set; }
        DialogAction Negative { get; set; }

        IReadOnlyList<DialogAction> Actions { get; }
        IReadOnlyList<TextEntry> TextEntries { get; }

        IAlertDialog Add(TextEntry instance);
        IAlertDialog Add(DialogAction action);

        void Show();
        void Dismiss();

        // TODO: what about outside cancel?
        Action Dismissed { get; set; }
    }
}
