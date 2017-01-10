//using System;
//using Android.App;
//using Android.OS;


//namespace Acr.UserDialogs.AppCompat
//{
//    public class AcrDialogFragment : DialogFragment
//    {
//        public override Dialog OnCreateDialog(Bundle savedInstanceState)
//        {
//            return base.OnCreateDialog(savedInstanceState);
//        }


//        public override void OnSaveInstanceState(Bundle bundle)
//        {
//            base.OnSaveInstanceState(bundle);
//        }


//        public override void OnDetach()
//        {
//            base.OnDetach();
//        }
//    }
//}
///*
// //PROMPT
// protected override void OnKeyPress(object sender, DialogKeyEventArgs args)
//        {
//            base.OnKeyPress(sender, args);
//            args.Handled = false;

//            switch (args.KeyCode)
//            {
//                case Keycode.Back:
//                    args.Handled = true;
//                    if (this.Config.IsCancellable)
//                        this.SetAction(false);
//                    break;

//                case Keycode.Enter:
//                    args.Handled = true;
//                    this.SetAction(true);
//                    break;
//            }
//        }

//        protected override Dialog CreateDialog(PromptConfig config)
//        {
//            return new PromptBuilder().Build(this.Activity, config);
//        }


//        protected virtual void SetAction(bool ok)
//        {
//            var txt = this.Dialog.FindViewById<TextView>(Int32.MaxValue);
//            this.Config?.OnAction(new PromptResult(ok, txt.Text.Trim()));
//            this.Dismiss();
//        }
// *
// //ACTIONSHEET
//            dialog.Window.SetSoftInputMode(SoftInput.StateVisible);
//            dialog.KeyPress += this.OnKeyPress;
//            if (this.Config.Cancel == null)
//            {
//                dialog.SetCancelable(false);
//                dialog.SetCanceledOnTouchOutside(false);
//            }
//            else
//            {
//                dialog.SetCancelable(true);
//                dialog.SetCanceledOnTouchOutside(true);
//                dialog.CancelEvent += (sender, args) => this.Config.Cancel.Action.Invoke();
//            }


// // ABSTRACT
//public T Config { get; set; }


//        public override void OnSaveInstanceState(Bundle bundle)
//        {
//            base.OnSaveInstanceState(bundle);
//            ConfigStore.Instance.Store(bundle, this.Config);
//        }


//        public override Dialog OnCreateDialog(Bundle bundle)
//        {
//            if (this.Config == null)
//                this.Config = ConfigStore.Instance.Pop<T>(bundle);

//            var dialog = this.CreateDialog(this.Config);
//            this.SetDialogDefaults(dialog);

//            return dialog;
//        }


//        public override void OnDetach()
//        {
//            base.OnDetach();
//            if (this.Dialog != null)
//                this.Dialog.KeyPress -= this.OnKeyPress;
//        }


//        protected virtual void SetDialogDefaults(Dialog dialog)
//        {
//            dialog.Window.SetSoftInputMode(SoftInput.StateVisible);
//            dialog.SetCancelable(false);
//            dialog.SetCanceledOnTouchOutside(false);
//            dialog.KeyPress += this.OnKeyPress;
//        }
// *
// *         protected override void OnKeyPress(object sender, DialogKeyEventArgs args)
//        {
//            base.OnKeyPress(sender, args);
//            if (args.KeyCode != Keycode.Back)
//                return;

//            args.Handled = true;
//            this.Config?.OnAction?.Invoke();
//            this.Dismiss();
//    }


//public string BundleKey { get; set; } = "UserDialogFragmentConfig";
//        long counter = 0;
//        readonly IDictionary<long, object> configStore = new Dictionary<long, object>();


//        public static ConfigStore Instance { get; } = new ConfigStore();


//        public void Store(Bundle bundle, object config)
//        {
//            this.counter++;
//            this.configStore[this.counter] = config;
//            bundle.PutLong(this.BundleKey, this.counter);
//        }


//        public T Pop<T>(Bundle bundle)
//        {
//            var id = bundle.GetLong(this.BundleKey);
//            var cfg = (T)this.configStore[id];
//            this.configStore.Remove(id);
//            return cfg;
//        }
//     */
