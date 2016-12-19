using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Acr.UserDialogs
{
    public abstract class AbstractAlertDialog : IAlertDialog

    {
        protected AbstractAlertDialog()
        {
            this.TextEntries = new ReadOnlyCollection<ITextEntry>(this.InternalTextEntries);
            this.Actions = new ReadOnlyCollection<IDialogAction>(this.InternalActions);
        }


        ~AbstractAlertDialog()
        {
            Dispose(false);
        }


        public abstract void Show();
        public abstract void Dismiss();

        protected List<ITextEntry> InternalTextEntries { get; } = new List<ITextEntry>();
        protected List<IDialogAction> InternalActions { get; } = new List<IDialogAction>();


        public string Message { get; set; }
        public string Title { get; set; }
        public bool IsCancellable { get; set; }
        public IDialogAction Positive { get; set; }
        public IDialogAction Neutral { get; set; }
        public IDialogAction Negative { get; set; }
        public Action<IDialogAction> Dismissed { get; set; }
        public IReadOnlyList<IDialogAction> Actions { get; }
        public IReadOnlyList<ITextEntry> TextEntries { get; }


        public IAlertDialog Add(ITextEntry entry)
        {
            this.InternalTextEntries.Add(entry);
            return this;
        }


        public IAlertDialog Add(IDialogAction action)
        {
            this.InternalActions.Add(action);
            return this;
        }


        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
        }
    }
}