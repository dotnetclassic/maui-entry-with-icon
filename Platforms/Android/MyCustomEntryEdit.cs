using Android.Content;
using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;


namespace MauiTestApp.Platforms.Android
{
    public class MyCustomEntryEdit : AppCompatEditText
    {
        private Drawable drawableRight;
        private Drawable drawableLeft;
        private Drawable drawableTop;
        private Drawable drawableBottom;

        public MyCustomEntryEdit(Context context) : base(context)
        {
        }

        public override void SetCompoundDrawablesWithIntrinsicBounds(Drawable left, Drawable top,
          Drawable right, Drawable bottom)
        {
            if (left is not null)
            {
                drawableLeft = left;
            }
            if (right is not null)
            {
                drawableRight = right;
            }
            if (top is not null)
            {
                drawableTop = top;
            }
            if (bottom is not null)
            {
                drawableBottom = bottom;
            }
            base.SetCompoundDrawablesWithIntrinsicBounds(left, top, right, bottom);
        }
    }
}
