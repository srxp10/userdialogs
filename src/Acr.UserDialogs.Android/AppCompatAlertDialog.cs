using System;
using System.Collections.Generic;
using Android.Support.V7.App;


namespace Acr.UserDialogs
{
    public class AppCompatAlertDialog : IAlertDialog
    {
        readonly AppCompatActivity activity;


        public AppCompatAlertDialog(AppCompatActivity activity)
        {
            this.activity = activity;
        }


        public string Message { get; set; }
        public string Title { get; set; }
        public bool IsCancellable { get; set; }
        public IAction Positive { get; set; }
        public IAction Neutral { get; set; }
        public IAction Negative { get; set; }
        public IList<IAction> Actions { get; } = new List<IAction>();
        public IList<ITextEntry> TextBoxes { get; } = new List<ITextEntry>();
        public IAlertDialog AddTextBox(Action<ITextEntry> instance)
        {
            throw new NotImplementedException();
        }

        public IAlertDialog AddAction(Action<IAction> button)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Dismiss()
        {
            throw new NotImplementedException();
        }

        public Action Dimissed { get; set; }
    }
}