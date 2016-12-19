using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public interface IDialogConfig
    {
        string Title { get; set; }
        string Message { get; set; }
        bool IsCancellable { get; set; }
        IDialogAction Positive { get; set; }
        IDialogAction Neutral { get; set; }
        IDialogAction Negative { get; set; }

        Color? BackgroundColor { get; set; }
        Color? TextColor { get; set; }
    }
}
