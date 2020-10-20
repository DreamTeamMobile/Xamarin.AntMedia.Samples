// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DT.WebRTC.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton actionButton { get; set; }

		[Outlet]
		UIKit.UIView fullContainer { get; set; }

		[Outlet]
		UIKit.UISegmentedControl modeSegments { get; set; }

		[Outlet]
		UIKit.UIButton muteAudioButton { get; set; }

		[Outlet]
		UIKit.UIButton muteVideoButton { get; set; }

		[Outlet]
		UIKit.UIView secondaryContainer { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint secondaryHeight { get; set; }

		[Outlet]
		UIKit.UIButton switchCameraButton { get; set; }

		[Action ("doAction:")]
		partial void doAction (Foundation.NSObject sender);

		[Action ("modeChanged:")]
		partial void modeChanged (Foundation.NSObject sender);

		[Action ("muteAudio:")]
		partial void muteAudio (Foundation.NSObject sender);

		[Action ("muteVideo:")]
		partial void muteVideo (Foundation.NSObject sender);

		[Action ("switchCamera:")]
		partial void switchCamera (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (actionButton != null) {
				actionButton.Dispose ();
				actionButton = null;
			}

			if (fullContainer != null) {
				fullContainer.Dispose ();
				fullContainer = null;
			}

			if (modeSegments != null) {
				modeSegments.Dispose ();
				modeSegments = null;
			}

			if (secondaryContainer != null) {
				secondaryContainer.Dispose ();
				secondaryContainer = null;
			}

			if (secondaryHeight != null) {
				secondaryHeight.Dispose ();
				secondaryHeight = null;
			}

			if (muteAudioButton != null) {
				muteAudioButton.Dispose ();
				muteAudioButton = null;
			}

			if (switchCameraButton != null) {
				switchCameraButton.Dispose ();
				switchCameraButton = null;
			}

			if (muteVideoButton != null) {
				muteVideoButton.Dispose ();
				muteVideoButton = null;
			}
		}
	}
}
