using System;
using System.Drawing;
using Foundation;
using Splat;
using UIKit;


namespace Acr.UserDialogs
{
    public class ActionImpl : IAction
    {
        UIAlertAction alertAction;

        public DialogChoice Choice { get; set; } = DialogChoice.Positive;
        public string Label { get; set; }


        bool enabled = true;
        public bool Enabled
        {
            get { return this.enabled; }
            set
            {
                this.enabled = value;
                if (this.alertAction != null)
                    this.alertAction.Enabled = value;
            }
        }


        public Color? TextColor { get; set; }
        public Color? BackgroundColor { get; set; }
        public IBitmap Icon { get; set; }
        public Action<IAction> Tap { get; set; }


        public UIAlertAction Create()
        {
            this.alertAction = UIAlertAction.Create(this.Label, this.ToStyle(), x => this.Tap?.Invoke(this));
            if (this.Icon != null)
                this.alertAction.SetValueForKey(this.Icon.ToNative(), new NSString("image"));

            this.alertAction.Enabled = this.Enabled;
            return this.alertAction;
        }


        UIAlertActionStyle ToStyle()
        {
            switch (this.Choice)
            {
                case DialogChoice.Negative:
                    return UIAlertActionStyle.Destructive;

                case DialogChoice.Neutral:
                    return UIAlertActionStyle.Cancel;

                default:
                    return UIAlertActionStyle.Default;
            }
        }
    }
}
