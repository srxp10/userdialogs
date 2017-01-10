using System;


namespace Acr.UserDialogs
{
    public class LoginConfig : AbstractDialogConfig
    {
        public TextEntry LoginEntry { get; set; }
        public TextEntry PasswordEntry { get; set; }
        public Action<DialogResult<Credentials>> OnAction { get; set; }
    }
}
