using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public class TextEntry : ITextEntry
    {
        public string Text { get; set; }
        public string Placeholder { get; set; }
        public int? MaxLength { get; set; }
        public KeyboardType Keyboard { get; set; }
        public Color? TextColor { get; set; }
        public Color? BackgroundColor { get; set; }
        public Action<ITextEntry> TextChanged { get; set; }
    }
}
