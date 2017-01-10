using System;
using Android.App;
using Android.Widget;


namespace Acr.UserDialogs
{
    public interface IEditTextBuilder
    {
        EditText Create(Activity activity, TextEntry entry);
    }
}