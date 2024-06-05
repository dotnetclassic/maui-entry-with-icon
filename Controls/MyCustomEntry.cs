using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Controls
{
    public class MyCustomEntry : Entry
    {
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(
         nameof(Image),
         typeof(ImageSource),
         typeof(MyCustomEntry),
         default(ImageSource));

        /// <summary>
        /// An ImageSource that you want to add to your ViewPort
        /// </summary>
        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }
    }
}
