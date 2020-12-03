using System.Threading.Tasks;
using DT.Configuration;
using DT.Xamarin.AntMedia.WebRTC.Forms;
using Xamarin.Forms;

namespace DT.WebRTC.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AntManager.Current.DefaultServer = InitialData.SERVER_URL;
            AntManager.Current.DefaultToken = InitialData.Token;
            AntFrame.StreamID = InitialData.DefaultStream;
            AntFrame.DataReceived += AntFrame_DataReceived;
            AntManager.Current.Ios_IAntMediaClientDelegate_DataReceivedFromDataChannelWithStreamId += Current_Ios_IAntMediaClientDelegate_DataReceivedFromDataChannelWithStreamId;
            AntManager.Current.Android_IDataChannelObserver_OnMessage += Instance_Android_IDataChannelObserver_OnMessage;
        }

        private void Current_Ios_IAntMediaClientDelegate_DataReceivedFromDataChannelWithStreamId(object sender, DataEventArgs e)
        {
            //receive only from iOS message from all streamId's here, filter by e.StreamId
        }

        private void Instance_Android_IDataChannelObserver_OnMessage(object sender, DataEventArgs e)
        {
            //receive only from Android message from all streamId's here, filter by e.StreamId
        }

        private void AntFrame_DataReceived(object sender, DataEventArgs e)
        {
            //receive for all Platforms message routed from AntView by special StreamId
            Dispatcher.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("DataReceived", e.IsBinary ? "[Binary]" : e.Message, "ОK");
            });
        }

        void SomeActionButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (AntFrame.IsPublishing || AntFrame.IsPlaying)
            {
                AntFrame.Stop();
                DelayedRestart();//if publishing that will make rendering from camera to layout as preview
            }
            else
            {
                AntFrame.Start();
            }
        }

        protected async Task DelayedRestart()
        {
            await Task.Delay(500);
            AntFrame.Init();
        }

        void ToggleAudioButton_Clicked(System.Object sender, System.EventArgs e)
        {
            AntFrame.ToggleAudio();
        }

        void ToggleVideoButton_Clicked(System.Object sender, System.EventArgs e)
        {
            AntFrame.ToggleVideo();
        }

        void SwitchCameraButton_Clicked(System.Object sender, System.EventArgs e)
        {
            AntFrame.SwitchCamera();
        }

        void AntFrame_Refresh(System.Object sender, System.EventArgs e)
        {
            RefreshState();
        }

        void RefreshState()
        {
            switch (AntFrame.WebRTCMode)
            {
                case Xamarin.AntMedia.WebRTC.Forms.AntWebRTCMode.Play:
                    SomeActionButton.Text = string.Format("{0} Playing", AntFrame.IsPlaying ? "Stop" : "Start");
                    PublishModeButton.IsVisible = !AntFrame.IsPlaying;
                    PlayModeButton.IsVisible = false;
                    break;
                case Xamarin.AntMedia.WebRTC.Forms.AntWebRTCMode.Publish:
                    SomeActionButton.Text = string.Format("{0} Publishing", AntFrame.IsPublishing ? "Stop" : "Start");
                    PlayModeButton.IsVisible = !AntFrame.IsPublishing;
                    PublishModeButton.IsVisible = false;
                    break;
            }
        }

        void PublishModeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!AntFrame.IsPlaying && !AntFrame.IsPublishing)
            {
                AntFrame.WebRTCMode = Xamarin.AntMedia.WebRTC.Forms.AntWebRTCMode.Publish;
                AntFrame.Init();
            }
                
            RefreshState();
        }

        void PlayModeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!AntFrame.IsPlaying && !AntFrame.IsPublishing)
            {
                AntFrame.WebRTCMode = Xamarin.AntMedia.WebRTC.Forms.AntWebRTCMode.Play;
                AntFrame.Init();
            }
            RefreshState();
        }

        void AntFrame_Error(System.Object sender, DT.Xamarin.AntMedia.WebRTC.Forms.ErrorEventArgs e)
        {
            DisplayAlert("Error", e.Message, "Ok");
            RefreshState();
        }

        void SendBinary_Clicked(System.Object sender, System.EventArgs e)
        {
            AntFrame.SendBinaryMessage(new byte[] { 2 });
        }

        void SendMsg_Clicked(System.Object sender, System.EventArgs e)
        {
            AntFrame.SendMessage("hello");
        }
    }
}
