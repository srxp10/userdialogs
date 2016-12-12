using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public abstract class AbstractDialogConfig : IDialogConfig
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsCancellable { get; set; }
        public IAction Positive { get; set; }
        public IAction Neutral { get; set; }
        public IAction Negative { get; set; }
        public Color? BackgroundColor { get; set; }
        public Color? TextColor { get; set; }
    }
}
