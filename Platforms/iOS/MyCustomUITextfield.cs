using Foundation;
using Microsoft.Maui.Platform;
using ObjCRuntime;

namespace MauiTestApp.Platforms.iOS
{
    public class MyCustomUITextfield : MauiTextField
    {
        public override bool CanPerform(Selector action, NSObject withSender)
        {
            return base.CanPerform(action, withSender);
        }
    }
}
