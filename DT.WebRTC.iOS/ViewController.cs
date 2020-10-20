using Foundation;
using System;
using UIKit;
using DT.Xamarin.AntMedia.WebRTC.iOS;
using DT.Configuration;
namespace DT.WebRTC.iOS
{
    public partial class ViewController : UIViewController, IAntMediaClientDelegate
    {
        protected AntMediaClient webRtcClient = new AntMediaClient();
        public bool IsStreamActive = false;

        /**
        * Mode can Publish, Play or P2P
        */
        protected AntMediaClientMode clientMode = AntMediaClientMode.Publish;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            refreshButtons();
            ReInitWebRTC();
        }

        protected void ReInitWebRTC()
        {
            if(webRtcClient != null)
            {
                Stop();
            }
            webRtcClient.Init();
            webRtcClient.WeakDelegate = this;
            webRtcClient.SetDebug(true);
            webRtcClient.SetOptionsWithUrl(InitialData.SERVER_URL, InitialData.DefaultStream, InitialData.Token, clientMode, enableDataChannel: true);

            switch (clientMode)
            {
                //P2P not tested
                //case AntMediaClientMode.Join:
                //    var small = new UIView(new CoreGraphics.CGRect(0, 0, 160, 240));
                //    secondaryHeight.Constant = 240;
                //    secondaryContainer.AddSubview(small);
                //    secondaryContainer.BackgroundColor = UIColor.LightGray;
                //    webRtcClient.SetLocalViewWithContainer(small, UIViewContentMode.ScaleAspectFit);
                //    webRtcClient.SetRemoteViewWithRemoteContainer(fullContainer, UIViewContentMode.ScaleAspectFit);
                //    break;
                case AntMediaClientMode.Play:
                    secondaryHeight.Constant = 0;
                    secondaryContainer.BackgroundColor = UIColor.Clear;
                    webRtcClient.SetRemoteViewWithRemoteContainer(fullContainer, UIViewContentMode.ScaleAspectFit);
                    break;
                case AntMediaClientMode.Publish:
                    webRtcClient.SetCameraPositionWithPosition(AVFoundation.AVCaptureDevicePosition.Front);
                    webRtcClient.SetLocalViewWithContainer(fullContainer, UIViewContentMode.ScaleAspectFit);
                    webRtcClient.SetVideoEnableWithEnable(true);
                    break;
            }

            webRtcClient.InitPeerConnection();
        }

        partial void modeChanged(NSObject sender)
        {
            clientMode = (AntMediaClientMode)(long)((nint)modeSegments.SelectedSegment + 1);
            ReInitWebRTC();
            refreshButtons();
        }

        private void Stop()
        {
            IsStreamActive = false;
            webRtcClient.Stop();
            foreach (var container in secondaryContainer.Subviews)
            {
                container.RemoveFromSuperview();
                container.Dispose();
            }
            secondaryHeight.Constant = 0;
            secondaryContainer.BackgroundColor = UIColor.Clear;
        }

        partial void muteAudio(NSObject sender)
        {
            webRtcClient.ToggleAudio();
        }

        partial void muteVideo(NSObject sender)
        {
            webRtcClient.ToggleVideo();
        }

        partial void switchCamera(NSObject sender)
        {
            webRtcClient.SwitchCamera();
        }

        partial void doAction(NSObject sender)
        {
            BeginInvokeOnMainThread(() =>
            {
                if (IsStreamActive)
                {
                    ReInitWebRTC();
                }
                else
                {
                    IsStreamActive = true;
                    if(webRtcClient == null)
                        ReInitWebRTC();
                    webRtcClient.Start();
                }
                UpdateViewConstraints();
                refreshButtons();
            });
        }

        public void refreshButtons()
        {
            switch (clientMode)
            {
                case AntMediaClientMode.Join:
                    actionButton.SetTitle(IsStreamActive ? "Stop" : "Join", UIControlState.Normal);
                    break;
                case AntMediaClientMode.Play:
                    actionButton.SetTitle(IsStreamActive ? "Stop" : "Play", UIControlState.Normal);
                    muteAudioButton.Hidden = muteVideoButton.Hidden = switchCameraButton.Hidden = true;
                    break;
                case AntMediaClientMode.Publish:
                    actionButton.SetTitle(IsStreamActive ? "Stop" : "Publish", UIControlState.Normal);
                    muteAudioButton.Hidden = muteVideoButton.Hidden = switchCameraButton.Hidden = IsStreamActive ? false : true;
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
                refreshButtons();
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
                refreshButtons();
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
                refreshButtons();
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