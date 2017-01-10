using System;
using System.Collections.Generic;


namespace Acr.UserDialogs
{

    public class ActionSheetConfig : AbstractDialogConfig
    {
        public IList<DialogAction> Actions { get; set; } = new List<DialogAction>();

        public bool UseBottomSheet { get; set; }
    }
}
