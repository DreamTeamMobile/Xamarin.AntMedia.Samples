using Foundation;
using System;
using UIKit;
using DT.Xamarin.AntMedia.WebRTC.iOS;
using DT.Configuration;
namespace DT.WebRTC.iOS
{
    public partial class ViewController : UIViewController, IAntMediaClientDelegate
    {
        protected AntMediaClient playClient = new AntMediaClient();
        public bool IsStreamActive = false;

        /**
        * Mode can Publish, Play or P2P
        */
        protected AntMediaClientMode clientMode = AntMediaClientMode.Join;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            updateButtonName();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        partial void modeChanged(NSObject sender)
        {
            clientMode = (AntMediaClientMode)(long)((nint)modeSegments.SelectedSegment + 1);
            if (IsStreamActive)
            {
                Stop();
            }
            updateButtonName();
        }

        private void Stop()
        {
            IsStreamActive = false;
            playClient.Stop();
            foreach (var container in secondaryContainer.Subviews)
            {
                container.RemoveFromSuperview();
                container.Dispose();
            }
            secondaryHeight.Constant = 0;
            secondaryContainer.BackgroundColor = UIColor.Clear;
        }

        partial void doAction(NSObject sender)
        {
            BeginInvokeOnMainThread(() =>
            {
                if (IsStreamActive)
                {
                    Stop();
                }
                else
                {
                    IsStreamActive = true;
                    playClient.Init();
                    playClient.WeakDelegate = this;
                    playClient.SetDebug(true);
                    playClient.SetOptionsWithUrl(InitialData.SERVER_URL, InitialData.DefaultStream, InitialData.Token, clientMode, enableDataChannel: true);
                    var small = new UIView(new CoreGraphics.CGRect(0, 0, 160, 240));
                    switch (clientMode)
                    {
                        case AntMediaClientMode.Join:
                            secondaryHeight.Constant = 240;
                            secondaryContainer.AddSubview(small);
                            secondaryContainer.BackgroundColor = UIColor.LightGray;
                            playClient.SetLocalViewWithContainer(small, UIViewContentMode.ScaleAspectFit);
                            playClient.SetRemoteViewWithRemoteContainer(fullContainer, UIViewContentMode.ScaleAspectFit);
                            break;
                        case AntMediaClientMode.Play:
                            secondaryHeight.Constant = 0;
                            secondaryContainer.BackgroundColor = UIColor.Clear;
                            playClient.SetRemoteViewWithRemoteContainer(fullContainer, UIViewContentMode.ScaleAspectFit);
                            break;
                        case AntMediaClientMode.Publish:
                            secondaryHeight.Constant = 240;
                            secondaryContainer.BackgroundColor = UIColor.LightGray;
                            secondaryContainer.AddSubview(small);
                            playClient.SetCameraPositionWithPosition(AVFoundation.AVCaptureDevicePosition.Front);
                            playClient.SetTargetResolutionWithWidth(160, 240);
                            playClient.SetLocalViewWithContainer(small, UIViewContentMode.ScaleAspectFit);
                            break;
                    }
                    playClient.InitPeerConnection();
                    playClient.Start();
                }
                UpdateViewConstraints();
                updateButtonName();
            });
        }

        public void updateButtonName()
        {
            switch (clientMode)
            {
                case AntMediaClientMode.Join:
                    actionButton.SetTitle(IsStreamActive ? "Stop" : "Join", UIControlState.Normal);
                    break;
                case AntMediaClientMode.Play:
                    actionButton.SetTitle(IsStreamActive ? "Stop" : "Play", UIControlState.Normal);
                    break;
                case AntMediaClientMode.Publish:
                    actionButton.SetTitle(IsStreamActive ? "Stop" : "Publish", UIControlState.Normal);
                    break;
            }
        }
        #region Ant Delegate
        public void ClientDidConnect(AntMediaClient client) { }

        public void ClientDidDisconnect(string message)
        {
            BeginInvokeOnMainThread(() =>
            {
                IsStreamActive = false;
                updateButtonName();
            });
        }

        public void ClientHasError(string message)
        {
            BeginInvokeOnMainThread(() =>
            {
                var controller = UIAlertController.Create("Error", message, UIAlertControllerStyle.Alert);
                controller.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Destructive, null));
                PresentViewController(controller, true, null);
                IsStreamActive = false;
                updateButtonName();
            });
        }

        public void RemoteStreamStarted() { }

        public void RemoteStreamRemoved() { }

        public void LocalStreamStarted() { }

        public void PlayStarted() { }

        public void PlayFinished() { }

        public void PublishStarted() { }

        public void PublishFinished() { }

        public void Disconnected()
        {
            BeginInvokeOnMainThread(() =>
            {
                IsStreamActive = false;
                updateButtonName();
            });
        }

        public void AudioSessionDidStartPlayOrRecord() { }

        public void DataReceivedFromDataChannelWithStreamId(string streamId, NSData data, bool binary)
        {
            BeginInvokeOnMainThread(() =>
            {
                var controller = UIAlertController.Create("DataReceived on " + streamId, data.ToString(NSStringEncoding.UTF8), UIAlertControllerStyle.Alert);
                controller.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Destructive, null));
                PresentViewController(controller, true, null);
            });
        }
        #endregion
    }
}