using System;


namespace Acr.UserDialogs
{
    public class AlertConfig : AbstractDialogConfig
    {
        public Action<DialogChoice> OnAction { get; set; }
    }
}
