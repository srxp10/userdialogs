
using System;
using System.Drawing;
using UIKit;


namespace Acr.UserDialogs
{
    public class TextEntryImpl : ITextEntry
    {
        readonly UITextField native = new UITextField();


        public string Value
        {
            get { return this.native.Text; }
            set { this.native.Text = value; }
        }


        public string Placeholder
        {
            get { return this.native.Placeholder; }
            set { this.native.Placeholder = value; }
        }


        public int? MaxLength { get; set; }
        public KeyboardType InputType { get; set; }
        public Color? TextColor { get; set; }
        public Color? BackgroundColor { get; set; }
        public Action<ITextEntry> TextChanged { get; set; }
    }
}
