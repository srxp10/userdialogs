using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public interface IDialogConfig
    {
        string Title { get; set; }
        string Message { get; set; }
        bool IsCancellable { get; set; }
        IAction Positive { get; set; }
        IAction Neutral { get; set; }
        IAction Negative { get; set; }

        Color? BackgroundColor { get; set; }
        Color? TextColor { get; set; }
    }
}
