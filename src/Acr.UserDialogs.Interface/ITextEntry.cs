using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public interface ITextEntry
    {
        //string Label { get; set; }
        string Value { get; set; }
        string Placeholder { get; set; }
        int? MaxLength { get; set; }
        KeyboardType InputType { get; set; }

        Color? TextColor { get; set; }
        Color? BackgroundColor { get; set; }

        // TODO: border color
        // TODO: may want all dialogs
        Action<ITextEntry> TextChanged { get; set; }
    }
}
