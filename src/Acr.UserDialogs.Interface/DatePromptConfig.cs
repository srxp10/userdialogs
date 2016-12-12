using System;


namespace Acr.UserDialogs
{
    public class DatePromptConfig : AbstractDialogConfig
    {
        //public static DialogButton DefaultPositive { get; set; } = new DialogButton("Ok");
        //public static DialogButton DefaultNeutral { get; set; } = new DialogButton("Cancel");
        //public static DialogButton DefaultNegative { get; } = new DialogButton("Remove", false);
        public static DateTimeKind DefaultUnspecifiedDateTimeKindReplacement { get; set; } = DateTimeKind.Local;

        public DateTime? SelectedDate { get; set; }
        public DateTimeKind UnspecifiedDateTimeKindReplacement { get; set; } = DefaultUnspecifiedDateTimeKindReplacement;

        public Action<DialogResult<DateTime>> OnAction { get; set; }
        public DateTime? MinimumDate { get; set; }
        public DateTime? MaximumDate { get; set; }
    }
}
