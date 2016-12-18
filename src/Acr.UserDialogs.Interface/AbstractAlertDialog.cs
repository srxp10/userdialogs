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
            this.Actions = new ReadOnlyCollection<IAction>(this.InternalActions);
        }


        public abstract void Show();
        public abstract void Dismiss();
        protected abstract IAction CreateAction();
        protected abstract ITextEntry CreateTextEntry();


        protected List<ITextEntry> InternalTextEntries { get; } = new List<ITextEntry>();
        protected List<IAction> InternalActions { get; } = new List<IAction>();


        public string Message { get; set; }
        public string Title { get; set; }
        public bool IsCancellable { get; set; }
        public IAction Positive { get; private set; }
        public IAction Neutral { get; private set; }
        public IAction Negative { get; private set; }
        public Action Dismissed { get; set; }
        public IReadOnlyList<IAction> Actions { get; }
        public IReadOnlyList<ITextEntry> TextEntries { get; }


        public IAlertDialog SetMainAction(DialogChoice choice, Action<IAction> action)
        {
            var obj = this.CreateAction();
            action(obj);

            switch (choice)
            {
                case DialogChoice.Positive:
                    this.Positive = obj;
                    break;

                case DialogChoice.Negative:
                    this.Negative = obj;
                    break;

                case DialogChoice.Neutral:
                    this.Neutral = obj;
                    break;
            }
            return this;
        }


        public IAlertDialog AddTextBox(Action<ITextEntry> instance)
        {
            var txt = this.CreateTextEntry();
            instance(txt);
            this.InternalTextEntries.Add(txt);
            return this;
        }


        public IAlertDialog AddAction(Action<IAction> action)
        {
            var obj = this.CreateAction();
            action(obj);
            this.InternalActions.Add(obj);

            return this;
        }
    }
}