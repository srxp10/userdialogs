using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public interface IDialogConfig
    {
        string Title { get; set; }
        string Message { get; set; }
        bool IsCancellable { get; set; }
        DialogButton Positive { get; set; }
        DialogButton Neutral { get; set; }
        DialogButton Negative { get; set; }
        int? AndroidStyleId { get; set; }

        //Color? BackgroundColor { get; set; }
        //Color? TextColor { get; set; }
    }
}
