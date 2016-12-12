using System;


namespace Acr.UserDialogs
{
    public class TimePromptConfig : AbstractDialogConfig
    {
        //public static DialogButton DefaultNegative { get; } = new DialogButton(DialogChoice.Negative, "Remove", null, false);
        public static int DefaultMinuteInterval { get; set; } = 1;
        public static bool? DefaultUse24HourClock { get; set; }

        public bool? Use24HourClock { get; set; } = DefaultUse24HourClock;
        public TimeSpan? SelectedTime { get; set; }


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
