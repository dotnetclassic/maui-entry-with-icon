using MauiTestApp.Controls;
using Microsoft.Maui.Handlers;


namespace MauiTestApp.Handlers
{
    public sealed partial class MyCustomEntryHandler : EntryHandler
    {

        public MyCustomEntryHandler()
        {
            Mapper.AppendToMapping(nameof(MyCustomEntryHandler), MapMyCustomEntry);
        }

        private void MapMyCustomEntry(IEntryHandler entryHandler, IEntry entry)
        {
            if (entry is MyCustomEntry myCustomEntry && entryHandler is MyCustomEntryHandler mycustomEntryHandler)
            {
                if (PlatformView is not null && VirtualView is not null)
                {
                    if (myCustomEntry.ImageSource != default(ImageSource))
                    {
                        HandleAndAlignImageSourceAsync(myCustomEntry);
                    }
                }
            }
        }
       
    }
}
