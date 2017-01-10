using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public interface IDialogConfig
    {
        string Title { get; set; }
        string Message { get; set; }
        bool IsCancellable { get; set; }
        DialogAction Positive { get; set; }
        DialogAction Neutral { get; set; }
        DialogAction Negative { get; set; }

        Color? BackgroundColor { get; set; }
        Color? TextColor { get; set; }
    }
}
