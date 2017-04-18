//
// ViewController.cs
//
// Author:
//     jzeferino jorgevalentzeferino@gmail.com
//
// Copyright 2017 jzeferino
//
using System;
using Foundation;
using UIKit;

namespace Xamarin.ResxConverter.Sample.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Label.Text = string.Format(NSBundle.MainBundle.LocalizedString("sample_string", "sample_string"));
        }
    }
}
