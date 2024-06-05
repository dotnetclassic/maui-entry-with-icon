using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if WINDOWS
using Microsoft.Maui.Controls.Platform;
#endif

#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using static Microsoft.Maui.ApplicationModel.Platform;
using NativeImage = Android.Graphics.Bitmap;
#endif

#if IOS
using NativeImage = UIKit.UIImage;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
#endif

using MauiTestApp.Handlers;
using MauiTestApp.Controls;


namespace MauiTestApp.Extensions
{
    public static class Extensions
    {
        public static MauiAppBuilder InitializeControl(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(builders => builders.AddHandlers());
            return builder;
        }

        private static void AddHandlers(this IMauiHandlersCollection handlers)
        {
            handlers.AddHandler(typeof(MyCustomEntry), typeof(MyCustomEntryHandler));
        }

#if ANDROID || IOS
        public static async Task<NativeImage> ToNativeImageSourceAsync(this ImageSource source)
        {
            var handler = GetHandler(source);
            var returnValue = (NativeImage)null;
        
            #if IOS
                returnValue = await handler.LoadImageAsync(source);
            #endif
            #if ANDROID
                returnValue = await handler.LoadImageAsync(source, CurrentActivity);
            #endif
            return returnValue;
        }

        private static IImageSourceHandler GetHandler(this ImageSource source)
        {
            //ImageSource handler to return
            IImageSourceHandler returnValue = null;
            //check the specific source type and return the correct ImageSource handler
            switch (source)
            {
                case UriImageSource:
                    returnValue = new ImageLoaderSourceHandler();
                    break;

                case FileImageSource:
                    returnValue = new FileImageSourceHandler();
                    break;

                case StreamImageSource:
                    returnValue = new StreamImagesourceHandler();
                    break;

                case FontImageSource:
                    returnValue = new FontImageSourceHandler();
                    break;
            }
            return returnValue;
        }
#endif
    }
}
