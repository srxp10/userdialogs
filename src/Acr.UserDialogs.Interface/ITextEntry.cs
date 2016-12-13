using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public interface ITextEntry
    {
        //string Label { get; set; }
        string Text { get; set; }
        string Placeholder { get; set; }
        int? MaxLength { get; set; }
        KeyboardType Keyboard { get; set; }

        Color? TextColor { get; set; }
        Color? BackgroundColor { get; set; }


        Action<ITextEntry> TextChanged { get; set; }

        // TODO: border color
        // TODO: may want all dialogs
        // TODO: int Lines { get; set; }
        // TODO: bool SingleLine { get; set; }
    }
}
