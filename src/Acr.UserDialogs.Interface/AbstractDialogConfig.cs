using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public abstract class AbstractDialogConfig : IDialogConfig
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsCancellable { get; set; }
        public IDialogAction Positive { get; set; }
        public IDialogAction Neutral { get; set; }
        public IDialogAction Negative { get; set; }
        public Color? BackgroundColor { get; set; }
        public Color? TextColor { get; set; }
    }
}
