using System;
using System.Drawing;
using Splat;


namespace Acr.UserDialogs
{
    public class DialogAction : IDialogAction
    {
        public DialogChoice Choice { get; set; }
        public string Label { get; set; }
        public bool Enabled { get; set; }
        public Color? TextColor { get; set; }
        public Color? BackgroundColor { get; set; }
        public IBitmap Icon { get; set; }
        public Action<IDialogAction> Tap { get; set; }
    }
}
