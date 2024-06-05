using Android.Graphics;
using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;
using MauiTestApp.Controls;
using MauiTestApp.Extensions;
using MauiTestApp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Platform;
using Microsoft.Maui.Handlers;
using MauiTestApp.Platforms.Android;


namespace MauiTestApp.Handlers
{
    public partial class MyCustomEntryHandler
    {
        protected override AppCompatEditText CreatePlatformView()
        {
            var _nativeView = new MyCustomEntryEdit(Context);
            return _nativeView;
        }

        internal async Task HandleAndAlignImageSourceAsync(MyCustomEntry entry)
        {
            var imageBitmap = await entry.ImageSource?.ToNativeImageSourceAsync();
            if (imageBitmap is not null)
            {
                var bitmapDrawable = new BitmapDrawable(CurrentActivity.Resources,
                    Bitmap.CreateScaledBitmap(imageBitmap, 50 * 2, 50 * 2, true));
                try
                {
                    var editText = (PlatformView as MyCustomEntryEdit);
                    editText.SetCompoundDrawablesWithIntrinsicBounds(bitmapDrawable, null, null, null);
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
