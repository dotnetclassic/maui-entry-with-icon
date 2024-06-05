using MauiTestApp.Controls;
using MauiTestApp.MVVM.Views;

namespace MauiTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var mainPage = new NavigationPage(new MainPage());
            //MainPage = mainPage;


            MainPage = new FormView();
            //Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(MyCustomEntry), (handler, view) => {
            //#if __ANDROID__
            //    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            //#elif __IOS__
            //    handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            //    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
            //#endif
            //});
        }
    }
}
