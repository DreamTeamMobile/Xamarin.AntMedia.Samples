using System.Threading.Tasks;
using DT.Configuration;
using Xamarin.Forms;

namespace DT.WebRTC.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AntFrame.Server = InitialData.SERVER_URL;
            AntFrame.Token = InitialData.Token;
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
    }
}
