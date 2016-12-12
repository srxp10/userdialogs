using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;


namespace Acr.UserDialogs
{
    public class AlertDialogImpl : IAlertDialog
    {
        UIAlertController alert;


        public string Message { get; set; }
        public string Title { get; set; }
        public bool IsCancellable { get; set; }
        public IAction Positive { get; set; }
        public IAction Neutral { get; set; }
        public IAction Negative { get; set; }
        public IList<IAction> Actions { get; } = new List<IAction>();
        public IList<ITextEntry> TextEntries { get; } = new List<ITextEntry>();


        public IAlertDialog AddTextBox(Action<ITextEntry> instance)
        {
            return this;
        }


        public IAlertDialog AddAction(Action<IAction> button)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            var style = this.Actions.Any() ? UIAlertControllerStyle.ActionSheet : UIAlertControllerStyle.Alert;
            this.alert = UIAlertController.Create(this.Title, this.Message, style);

            foreach (var action in this.Actions)
            {
                this.alert.AddAction(null);
            }
            foreach (var txt in this.TextEntries)
            {
                this.alert.AddTextField(x => { });
            }
            // TODO: display func
        }


        public void Dismiss()
        {
            this.alert?.DismissViewController(true, null);
        }

        public Action Dismissed { get; set; }
    }
}
