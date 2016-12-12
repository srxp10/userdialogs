using System;
using System.Drawing;


namespace Acr.UserDialogs
{
    public class LoginConfig : AbstractDialogConfig
    {
        public ITextEntry LoginEntry { get; set; }
        public ITextEntry PasswordEntry { get; set; }
        public Action<DialogResult<Credentials>> OnAction { get; set; }
    }
}
