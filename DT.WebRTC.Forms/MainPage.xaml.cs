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
    }
}
