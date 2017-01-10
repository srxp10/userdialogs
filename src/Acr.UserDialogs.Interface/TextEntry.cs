using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public class TextEntry : AbstractNpc
    {
        //string Label { get; set; }
        //int Lines { get; set; }

        string text;
        public string Text
        {
            get { return this.text; }
            set { this.SetProperty(ref this.text, value); }
        }


        string placeholder;
        public string Placeholder
        {
            get { return this.placeholder; }
            set { this.SetProperty(ref this.placeholder, value); }
        }


        int? maxLength;
        public int? MaxLength
        {
            get { return this.maxLength; }
            set { this.SetProperty(ref this.maxLength, value); }
        }


        KeyboardType keyboardType = KeyboardType.Default;
        public KeyboardType Keyboard
        {
            get { return this.keyboardType; }
            set { this.SetProperty(ref this.keyboardType, value); }
        }


        Color? textColor;
        public Color? TextColor
        {
            get { return this.textColor; }
            set { this.SetProperty(ref this.textColor, value); }
        }


        Color? bgColor;
        public Color? BackgroundColor
        {
            get { return this.bgColor; }
            set { this.SetProperty(ref this.bgColor, value); }
        }


        Action<TextEntry> TextChanged { get; set; }

        // TODO: border color
        // TODO: may want all dialogs
        // TODO: int Lines { get; set; }
        // TODO: bool SingleLine { get; set; }
    }
}
