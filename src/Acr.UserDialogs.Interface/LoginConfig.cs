using System;
using System.Drawing;


namespace Acr.UserDialogs
{

    public class LoginConfig : AbstractDialogConfig
    {
        public LoginConfig()
        {
            this.Title = DefaultTitle;
            this.Positive = DefaultPositive?.Clone();
            this.Neutral = DefaultNeutral?.Clone();
            this.Negative = DefaultNegative?.Clone();
            this.AndroidStyleId = DefaultAndroidStyleId;
            this.IsCancellable = DefaultIsCancellable;
        }


        public static string DefaultTitle { get; set; } = "Login";
        public static DialogButton DefaultPositive { get; set; } = new DialogButton("Ok");
        public static DialogButton DefaultNeutral { get; set; } = new DialogButton("Cancel");
        public static DialogButton DefaultNegative { get; set; }
        public static string DefaultLoginPlaceholder { get; set; } = "User Name";
        public static string DefaultPasswordPlaceholder { get; set; } = "Password";
        public static Color? DefaultBackgroundColor { get; set; }
        public static int? DefaultAndroidStyleId { get; set; }
        public static bool DefaultIsCancellable { get; set; } = true;

        public string LoginValue { get; set; }
        public string LoginPlaceholder { get; set; } = DefaultLoginPlaceholder;
        public string PasswordPlaceholder { get; set; } = DefaultPasswordPlaceholder;
        public Action<DialogResult<Credentials>> OnAction { get; set; }


        public LoginConfig SetText(DialogChoice choice, string text = null)
        {
            //switch (choice)
            //{
            //    case DialogChoice.Negative:
            //        this.Negative.Text = text ?? DefaultNegative.Text;
            //        this.Negative.IsVisible = true;
            //        break;

            //    case DialogChoice.Neutral:
            //        this.Neutral.Text = text ?? DefaultNeutral.Text;
            //        this.Neutral.IsVisible = true;
            //        break;

            //    case DialogChoice.Positive:
            //        this.Positive.Text = text ?? DefaultPositive.Text;
            //        this.Positive.IsVisible = true;
            //        break;
            //}
            return this;
        }


        public LoginConfig SetTitle(string title)
        {
            this.Title = title;
            return this;
        }


        public LoginConfig SetMessage(string msg)
        {
            this.Message = msg;
            return this;
        }


        public LoginConfig SetLoginValue(string txt)
        {
            this.LoginValue = txt;
            return this;
        }


        public LoginConfig SetLoginPlaceholder(string txt)
        {
            this.LoginPlaceholder = txt;
            return this;
        }


        public LoginConfig SetPasswordPlaceholder(string txt)
        {
            this.PasswordPlaceholder = txt;
            return this;
        }


        public LoginConfig SetAction(Action<DialogResult<Credentials>> action)
        {
            this.OnAction = action;
            return this;
        }
    }
}
