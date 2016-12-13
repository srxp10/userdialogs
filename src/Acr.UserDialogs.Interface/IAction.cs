using System;
using System.Drawing;
using Splat;


namespace Acr.UserDialogs
{
    public interface IAction
    {
        DialogChoice Choice { get; set; }
        string Label { get; set; }
        bool Enabled { get; set; }
        Color? TextColor { get; set; }
        Color? BackgroundColor { get; set; }
        IBitmap Icon { get; set; }

        Action<IAction> Tap { get; set; }
        // TODO: border color
    }
}
