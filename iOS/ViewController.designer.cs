// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DragonPulse.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField charNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView profilePicView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton searchButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView testTextView { get; set; }

        [Action ("ClearCharacterNameText:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClearCharacterNameText (UIKit.UITextField sender);

        [Action ("SearchButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SearchButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (charNameTextField != null) {
                charNameTextField.Dispose ();
                charNameTextField = null;
            }

            if (profilePicView != null) {
                profilePicView.Dispose ();
                profilePicView = null;
            }

            if (searchButton != null) {
                searchButton.Dispose ();
                searchButton = null;
            }

            if (testTextView != null) {
                testTextView.Dispose ();
                testTextView = null;
            }
        }
    }
}