using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;


namespace Acr.UserDialogs
{
    public class AlertDialogImpl : IAlertDialog
    {
        readonly Func<UIViewController> viewControllerFunc;
        UIAlertController alert;


        public AlertDialogImpl(Func<UIViewController> viewControllerFunc)
        {
            this.viewControllerFunc = viewControllerFunc;
        }


        public string Message { get; set; }
        public string Title { get; set; }
        public bool IsCancellable { get; set; }
        public IAction Positive { get; set; }
        public IAction Neutral { get; set; }
        public IAction Negative { get; set; }
        public IReadOnlyList<IAction> Actions { get; } = new List<IAction>();
        public IReadOnlyList<ITextEntry> TextEntries { get; } = new List<ITextEntry>();


        public IAlertDialog AddTextBox(Action<ITextEntry> instance)
        {
            return this;
        }


        public IAlertDialog AddAction(Action<IAction> action)
        {
            var obj = new ActionImpl();
            action(obj);

            return this;
        }

        public void Show()
        {
            var style = this.Actions.Any() ? UIAlertControllerStyle.ActionSheet : UIAlertControllerStyle.Alert;
            this.alert = UIAlertController.Create(this.Title, this.Message, style);

            foreach (var action in this.Actions.OfType<ActionImpl>())
            {
                this.alert.AddAction(action.Create());
            }
            foreach (var txt in this.TextEntries.OfType<TextEntryImpl>())
            {
                this.alert.AddTextField(x => txt.Hook(x));
            }
            this.AddNativeMainAction(this.alert, this.Positive);
            this.AddNativeMainAction(this.alert, this.Negative);
            this.AddNativeMainAction(this.alert, this.Neutral);
            //var vc = this.viewControllerFunc();
        }


        public void Dismiss()
        {
            this.alert?.DismissViewController(true, null);
        }


        public Action Dismissed { get; set; }
        public IAlertDialog SetMainAction(DialogChoice choice, Action<IAction> action)
        {
            var obj = new ActionImpl { Choice = choice };
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


        void AddNativeMainAction(UIAlertController ctrl, IAction action)
        {
            var impl = action as ActionImpl;
            if (impl != null)
                ctrl.AddAction(impl.Create());
        }
        /*
            UIAlertController alert = null;
            var app = UIApplication.SharedApplication;
            app.InvokeOnMainThread(() =>
            {
                alert = alertFunc();
                var top = this.viewControllerFunc();
                if (alert.PreferredStyle == UIAlertControllerStyle.ActionSheet && UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
                {
                    var x = top.View.Bounds.Width / 2;
                    var y = top.View.Bounds.Bottom;
                    var rect = new CGRect(x, y, 0, 0);

                    alert.PopoverPresentationController.SourceView = top.View;
                    alert.PopoverPresentationController.SourceRect = rect;
                    alert.PopoverPresentationController.PermittedArrowDirections = UIPopoverArrowDirection.Unknown;
                }
                top.PresentViewController(alert, true, null);
            });
            return new DisposableAction(() =>
            {
                try
                {
                    app.InvokeOnMainThread(() => alert.DismissViewController(true, null));
                }
                catch { }
            });
         */
    }
}
