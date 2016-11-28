using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public class DialogButton
    {
        public DialogButton(string text, Color? textColor = null)
        {
            this.Text = text;
            this.TextColor = textColor;
        }


        public DialogButton Clone()
        {
            return new DialogButton(this.Text, this.TextColor);
        }


        public string Text { get; set; }
        public Color? TextColor { get; set; }
    }
}
