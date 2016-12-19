using System;
using System.Collections.Generic;


namespace Acr.UserDialogs
{

    public class ActionSheetConfig : AbstractDialogConfig
    {
        public IList<IDialogAction> Actions { get; set; } = new List<IDialogAction>();

        public bool UseBottomSheet { get; set; }
    }
}
