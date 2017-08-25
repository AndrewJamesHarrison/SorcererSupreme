using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using static Android.Resource;

namespace WizardTricks.SorcererSupreme
{
    public class Anim : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public void startAnimation()
        {
            ImageView imageView = FindViewById<ImageView>(Resource.Animation.anim_android);
            AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
            animation.Start();
        }
    }
}