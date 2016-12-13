using System;
using System.Drawing;
using Android.App;
using Android.Text;
using Android.Text.Method;
using Android.Widget;
using Splat;


namespace Acr.UserDialogs
{
    public class TextEntryImpl : ITextEntry
    {
        readonly EditText editText;


        public TextEntryImpl(Activity activity)
        {
            this.editText = new EditText(activity);
            this.editText.SetSingleLine(true);
            this.editText.TextChanged += (sender, args) => this.TextChanged?.Invoke(this);
        }


        public string Text
        {
            get { return this.editText.Text; }
            set { this.editText.Text = value; }
        }


        public string Placeholder
        {
            get { return this.editText.Hint; }
            set { this.editText.Hint = value;  }
        }


        int? maxLength;
        public int? MaxLength
        {
            get { return this.maxLength; }
            set
            {
                this.maxLength = value;
                if (value == null)
                    this.editText.SetFilters(null);
                else
                    this.editText.SetFilters(new [] { new InputFilterLengthFilter(value.Value) });
            }
        }


        KeyboardType keyboardType = KeyboardType.Name;

        public KeyboardType Keyboard
        {
            get { return this.keyboardType; }
            set
            {
                this.keyboardType = value;
                switch (value)
                {
                    case KeyboardType.DecimalNumber:
                        this.editText.InputType = InputTypes.ClassNumber | InputTypes.NumberFlagDecimal | InputTypes.NumberFlagSigned;
                        break;

                    case KeyboardType.Email:
                        this.editText.InputType = InputTypes.ClassText | InputTypes.TextVariationEmailAddress;
                        break;

                    case KeyboardType.Name:
                        this.editText.InputType = InputTypes.TextVariationPersonName;
                        break;

                    case KeyboardType.Number:
                        this.editText.InputType = InputTypes.ClassNumber;
                        break;

                    case KeyboardType.NumericPassword:
                        this.editText.InputType = InputTypes.ClassNumber;
                        this.editText.TransformationMethod = PasswordTransformationMethod.Instance;
                        break;

                    case KeyboardType.Password:
                        this.editText.TransformationMethod = PasswordTransformationMethod.Instance;
                        this.editText.InputType = InputTypes.ClassText | InputTypes.TextVariationPassword;
                        break;

                    case KeyboardType.Phone:
                        this.editText.InputType = InputTypes.ClassPhone;
                        break;

                    case KeyboardType.Url:
                        this.editText.InputType = InputTypes.TextVariationUri;
                        break;
                }
            }
        }


        Color? textColor;
        public Color? TextColor
        {
            get { return this.textColor; }
            set
            {
                this.textColor = value;
                this.editText.SetTextColor(value.Value.ToNative());
            }
        }


        Color? backgroundColor;
        public Color? BackgroundColor
        {
            get { return this.backgroundColor; }
            set
            {
                this.backgroundColor = value;
                this.editText.SetBackgroundColor(value.Value.ToNative());
            }
        }


        public Action<ITextEntry> TextChanged { get; set; }
    }
}