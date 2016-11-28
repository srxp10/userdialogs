using System;


namespace Acr.UserDialogs
{
    public class DatePromptConfig
    {
        public static DialogButton DefaultPositive { get; set; } = new DialogButton("Ok");
        public static DialogButton DefaultNeutral { get; set; } = new DialogButton("Cancel");
        //public static DialogButton DefaultNegative { get; } = new DialogButton("Remove", false);
        public static DateTimeKind DefaultUnspecifiedDateTimeKindReplacement { get; set; } = DateTimeKind.Local;


        public string Title { get; set; }
        public DialogButton Positive { get; set; } = DefaultPositive?.Clone();
        public DialogButton Neutral { get; set; } = DefaultNeutral?.Clone();
        //public DialogButton Negative { get; } = new DialogButton(DefaultNegative.Text, DefaultNegative.IsVisible, DefaultNegative.TextColor);

        public DateTime? SelectedDate { get; set; }
        public DateTimeKind UnspecifiedDateTimeKindReplacement { get; set; } = DefaultUnspecifiedDateTimeKindReplacement;

        public Action<DialogResult<DateTime>> OnAction { get; set; }
        public DateTime? MinimumDate { get; set; }
        public DateTime? MaximumDate { get; set; }
    }
}
