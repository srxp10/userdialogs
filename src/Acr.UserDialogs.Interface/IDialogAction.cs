using System;
using System.Drawing;
using Splat;


namespace Acr.UserDialogs
{
    public interface IDialogAction
    {
        //DialogChoice Choice { get; set; }
        string Label { get; set; }
        bool Enabled { get; set; }
        Color? TextColor { get; set; }
        Color? BackgroundColor { get; set; }
        IBitmap Icon { get; set; }

        Action<IDialogAction> Tap { get; set; }
        // TODO: border color
    }
}
