using System;
using System.Drawing;
using System.Windows.Input;
using Splat;


namespace Acr.UserDialogs
{
    public class DialogAction : AbstractNpc
    {
        // TODO: border color
        string label;
        public string Label
        {
            get { return this.label; }
            set { this.SetProperty(ref this.label, value); }
        }


        Color? textColor;
        public Color? TextColor
        {
            get { return this.textColor; }
            set { this.SetProperty(ref this.textColor, value); }
        }


        Color? bgColor;
        public Color? BackgroundColor
        {
            get { return this.bgColor; }
            set { this.SetProperty(ref this.bgColor, value); }
        }


        IBitmap icon;
        public IBitmap Icon
        {
            get { return this.icon; }
            set
            {
                this.icon = value;
                this.OnPropertyChanged();
            }
        }


        public ICommand Command { get; set; }
    }
}
