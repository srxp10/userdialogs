using System;
using Splat;


namespace Acr.UserDialogs 
{

    public class ActionSheetOption : DialogButton
    {
        public ActionSheetOption(string text, Action action = null, IBitmap icon = null) : base(text)
        {
            this.Text = text;
            this.Action = action;
            this.ItemIcon = icon;
        }


        public Action Action { get; set; }
        public IBitmap ItemIcon { get; set; }
    }
}
