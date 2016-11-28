using System;


namespace Acr.UserDialogs
{
    public class TimePromptConfig
    {
        public static DialogButton DefaultPositive { get; set; } = new DialogButton("Ok");
        public static DialogButton DefaultNeutral { get; set; } = new DialogButton("Cancel");
        //public static DialogButton DefaultNegative { get; } = new DialogButton(DialogChoice.Negative, "Remove", null, false);
        public static int DefaultMinuteInterval { get; set; } = 1;
        public static bool? DefaultUse24HourClock { get; set; }

        public string Title { get; set; }
        public bool? Use24HourClock { get; set; } = DefaultUse24HourClock;
        public TimeSpan? SelectedTime { get; set; }
        public DialogButton Positive { get; } = DefaultPositive?.Clone();
        public DialogButton Neutral { get; } = DefaultNeutral?.Clone();
        //public DialogButton Negative { get; } = new DialogButton(DialogChoice.Negative, DefaultNegative.Text, DefaultNegative.TextColor, DefaultNegative.IsVisible);


        public Action<DialogResult<TimeSpan>> OnAction { get; set; }

        /// <summary>
        /// Only valid on iOS
        /// </summary>
        public int? MinimumMinutesTimeOfDay { get; set; }

        /// <summary>
        /// Only valid on iOS
        /// </summary>
        public int? MaximumMinutesTimeOfDay { get; set; }

        /// <summary>
        /// Only valid on iOS
        /// </summary>
        public int MinuteInterval { get; set; } = DefaultMinuteInterval;
    }
}
