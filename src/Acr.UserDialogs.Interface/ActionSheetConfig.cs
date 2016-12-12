using System;


namespace Acr.UserDialogs
{

    public class ActionSheetConfig : AbstractDialogConfig
    {
        public IAction[] Actions { get; set; }

        public bool UseBottomSheet { get; set; }
    }
}
