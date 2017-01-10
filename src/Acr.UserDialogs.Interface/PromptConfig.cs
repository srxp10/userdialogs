using System;


namespace Acr.UserDialogs
{
    public class PromptConfig : AbstractDialogConfig
    {
        public TextEntry TextEntry { get; set; }
        public Action<DialogResult<string>> OnAction { get; set; }

        ///// <summary>
        ///// Setting this allows you to not only validate (enable/disable positive button) but also change the current text value of the prompt
        ///// </summary>
        //public Action<PromptTextChangedArgs> OnTextChanged { get; set; }


        //public PromptConfig SetText(DialogChoice choice, string text = null)
        //{
        //    switch (choice)
        //    {
        //        case DialogChoice.Negative:
        //            if (this.Negative == null)
        //                this.Negative = new DialogButton(text);
        //            else
        //                this.Negative.Text = text;
        //            break;

        //        case DialogChoice.Neutral:
        //            this.Neutral.Text = text ?? DefaultNeutral.Text;
        //            break;

        //        case DialogChoice.Positive:
        //            this.Positive.Text = text ?? DefaultPositive.Text;
        //            break;
        //    }
        //    return this;
        //}


        //public PromptConfig SetTitle(string title)
        //{
        //    this.Title = title;
        //    return this;
        //}


        //public PromptConfig SetMessage(string message)
        //{
        //    this.Message = message;
        //    return this;
        //}


        //public PromptConfig SetMaxLength(int maxLength)
        //{
        //    this.MaxLength = maxLength;
        //    return this;
        //}


        //public PromptConfig SetText(string text)
        //{
        //    this.Text = text;
        //    return this;
        //}


        //public PromptConfig SetPlaceholder(string placeholder)
        //{
        //    this.Placeholder = placeholder;
        //    return this;
        //}


        //public PromptConfig SetInputType(KeyboardType inputType)
        //{
        //    this.InputType = inputType;
        //    return this;
        //}


        //public PromptConfig SetOnTextChanged(Action<PromptTextChangedArgs> onChange)
        //{
        //    this.OnTextChanged = onChange;
        //    return this;
        //}
    }
}
