using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
        }

        void SomeActionButton_Clicked(System.Object sender, System.EventArgs e)
        {
            AntFrame.Init(InitialData.SERVER_URL, InitialData.Token);
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

        void AntFrame_PlayStarted(System.Object sender, System.EventArgs e)
        {
            SomeActionButton.Text = "Stop Playing";
        }

        void AntFrame_PlayFinished(System.Object sender, System.EventArgs e)
        {
            SomeActionButton.Text = "Start Playing";
        }

        void AntFrame_PublishStarted(System.Object sender, System.EventArgs e)
        {
            SomeActionButton.Text = "Stop Publish";
        }

        void AntFrame_PublishFinished(System.Object sender, System.EventArgs e)
        {
            SomeActionButton.Text = "Start Publish";
        }
    }
}
