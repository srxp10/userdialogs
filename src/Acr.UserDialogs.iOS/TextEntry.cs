
using System;
using System.Drawing;
using System.Text;
using UIKit;


namespace Acr.UserDialogs
{
    public class TextEntry : ITextEntry
    {
        UITextField native;


        string text;
        public string Text
        {
            get { return this.text; }
            set
            {
                this.text = value;
                if (this.native != null)
                    this.native.Text = value;
            }
        }


        private string placeholder;
        public string Placeholder
        {
            get { return this.placeholder; }
            set
            {
                this.placeholder = value;
                if (this.native != null)
                    this.native.Placeholder = value;
            }
        }


        public int? MaxLength { get; set; }
        public KeyboardType Keyboard { get; set; }
        public Color? TextColor { get; set; }
        public Color? BackgroundColor { get; set; }
        public Action<ITextEntry> TextChanged { get; set; }


        public void Hook(UITextField txt)
        {
            this.native = txt;

            txt.Placeholder = this.Placeholder ?? String.Empty;
            txt.Ended += (sender, e) => this.TextChanged?.Invoke(this);
            txt.ShouldChangeCharacters = (field, replacePosition, replacement) =>
            {
                if (this.MaxLength == null)
                    return true;

                var updatedText = new StringBuilder(field.Text);
                updatedText.Remove((int)replacePosition.Location, (int)replacePosition.Length);
                updatedText.Insert((int)replacePosition.Location, replacement);
                return updatedText.ToString().Length <= this.MaxLength.Value;
            };

            switch (this.Keyboard)
            {
                case KeyboardType.DecimalNumber:
                    txt.KeyboardType = UIKeyboardType.DecimalPad;
                    break;

                case KeyboardType.Email:
                    txt.KeyboardType = UIKeyboardType.EmailAddress;
                    break;

                case KeyboardType.Name:
                    break;

                case KeyboardType.Number:
                    txt.KeyboardType = UIKeyboardType.NumberPad;
                    break;

                case KeyboardType.NumericPassword:
                    txt.SecureTextEntry = true;
                    txt.KeyboardType = UIKeyboardType.NumberPad;
                    break;

                case KeyboardType.Password:
                    txt.SecureTextEntry = true;
                    break;

                case KeyboardType.Phone:
                    txt.KeyboardType = UIKeyboardType.PhonePad;
                    break;

                case KeyboardType.Url:
                    txt.KeyboardType = UIKeyboardType.Url;
                    break;
            }
        }
    }
}
