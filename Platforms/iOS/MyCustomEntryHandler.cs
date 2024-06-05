using MauiTestApp.Controls;
using MauiTestApp.Extensions;
using MauiTestApp.Platforms.iOS;
using Microsoft.Maui.Platform;
using System.Drawing;
using UIKit;

namespace MauiTestApp.Handlers
{
    public partial class MyCustomEntryHandler
    {
        protected override MauiTextField CreatePlatformView()
        {
            var mauiTextField = new MyCustomUITextfield
            {
                BorderStyle = UITextBorderStyle.None,
                ClipsToBounds = true,
            };
            mauiTextField.Layer.BorderWidth = 0;
            mauiTextField.Layer.BorderColor = UIColor.Clear.CGColor;
            return mauiTextField;
        }

        internal async Task HandleAndAlignImageSourceAsync(MyCustomEntry entry)
        {
            var uiImage = await entry.ImageSource?.ToNativeImageSourceAsync();
            if (uiImage is not null)
            {
                var uiImageView = new UIImageView(uiImage)
                {
                    Frame = new RectangleF(0, 0, 100, 100)
                };
                UIView uiView = new UIView(new Rectangle(0, 0, 100, 100));
                uiView.AddSubview(uiImageView);


                uiView.UserInteractionEnabled = true;
                PlatformView.LeftViewMode = UITextFieldViewMode.Always;
                PlatformView.LeftView = uiView;
            }
        }
    }
}
