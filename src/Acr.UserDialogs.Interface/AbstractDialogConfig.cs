using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public abstract class AbstractDialogConfig : IDialogConfig
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsCancellable { get; set; }
        public DialogAction Positive { get; set; }
        public DialogAction Neutral { get; set; }
        public DialogAction Negative { get; set; }
        public Color? BackgroundColor { get; set; }
        public Color? TextColor { get; set; }
    }
}
