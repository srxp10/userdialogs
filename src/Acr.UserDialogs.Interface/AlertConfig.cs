using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public class AlertConfig : AbstractDialogConfig
    {
        public AlertConfig()
        {
            this.Positive = DefaultPositive?.Clone();
            this.Neutral = DefaultNeutral?.Clone();
            this.Negative = DefaultNegative?.Clone();
            this.AndroidStyleId = DefaultAndroidStyleId;
            this.IsCancellable = DefaultIsCancellable;
        }


        public static DialogButton DefaultPositive { get; set; } = new DialogButton("Ok");
        public static DialogButton DefaultNeutral { get; set; } = new DialogButton("Cancel");
        public static DialogButton DefaultNegative { get; set; }
        public static bool DefaultIsCancellable { get; set; } = true;
        //public static Color? DefaultBackgroundColor { get; set; }
        public static int? DefaultAndroidStyleId { get; set; }
        public Action<DialogChoice> OnAction { get; set; }


        public AlertConfig SetText(DialogChoice choice, string text = null)
        {
            switch (choice)
            {
                case DialogChoice.Negative:
                    this.Negative.Text = text ?? DefaultNegative.Text;
                    break;

                case DialogChoice.Neutral:
                    this.Neutral.Text = text ?? DefaultNeutral.Text;
                    break;

                case DialogChoice.Positive:
                    this.Positive.Text = text ?? DefaultPositive.Text;
                    break;
            }
            return this;
        }


        public AlertConfig SetAction(Action<DialogChoice> action)
        {
            this.OnAction = action;
            return this;
        }


        public AlertConfig SetTitle(string title)
        {
            this.Title = title;
            return this;
        }


        public AlertConfig SetMessage(string message)
        {
            this.Message = message;
            return this;
        }
    }
}
