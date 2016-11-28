using System;


namespace Acr.UserDialogs
{
    public abstract class AbstractDialogConfig : IDialogConfig
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsCancellable { get; set; }
        public DialogButton Positive { get; set; }
        public DialogButton Neutral { get; set; }
        public DialogButton Negative { get; set; }
        public int? AndroidStyleId { get; set; }
    }
}
