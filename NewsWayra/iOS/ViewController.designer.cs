// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NewsWayra.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txfQuery { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnSearch != null) {
                btnSearch.Dispose ();
                btnSearch = null;
            }

            if (txfQuery != null) {
                txfQuery.Dispose ();
                txfQuery = null;
            }
        }
    }
}