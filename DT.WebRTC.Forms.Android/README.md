# Xamarin Forms WebRTC Sample app, Android project

Please follow our [WiKi](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki) to find information:

* [Documentation](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

* [Step by Step Tutorial](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC-Tutorial) how to add AntMedia WebRTC to Forms app

### How to use nuget

* to all projects, Core, iOS, Android - add nuget package [DT.Xamarin.AntMedia.WebRTC.Forms](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/)

* to Android project - add nuget package [DT.Xamarin.AntMedia.WebRTC.Android](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/)

* to iOS project - add nuget package [DT.Xamarin.AntMedia.WebRTC.iOS](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/)
<br> add `[assembly: ExportRenderer(typeof(AntWebRTCView), typeof(AntWebRTCViewRenderer))]` to [AppDelegate.cs](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.WebRTC.Forms.iOS/AppDelegate.cs), outside of namespaces
  ```
  using DT.Xamarin.AntMedia.WebRTC.Forms;
  using DT.Xamarin.AntMedia.WebRTC.Forms.iOS;
  using Foundation;
  using UIKit;
  using Xamarin.Forms;

  [assembly: ExportRenderer(typeof(AntWebRTCView), typeof(AntWebRTCViewRenderer))]

  namespace DT.WebRTC.Forms.iOS
  ...
  ```
* add reference to framework on page or some view in Core project
  ```xaml
  xmlns:ant="clr-namespace:DT.Xamarin.AntMedia.WebRTC.Forms;assembly=DT.Xamarin.AntMedia.WebRTC.Forms"
  ```
  and use special control
  ```
  <ant:AntWebRTCView
            x:Name="AntFrame"
            Grid.Column="0"
            Grid.ColumnSpan="3"
            Grid.Row="1"
            RenderingMode="ScaleAspectFit"
            WebRTCMode="Publish"
            Camera="Front"
            ShowDebugLogs="True"
            InitMode="InitOnViewRender"
            PlayStarted="AntFrame_Refresh"
            PlayFinished="AntFrame_Refresh"
            PublishStarted="AntFrame_Refresh"
            PublishFinished="AntFrame_Refresh"
            Error="AntFrame_Error"
            />
  ```
  to Start or Stop stream call where you need
  ```
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
  ```

* then you can use our [Documentation](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-iOS-WebRTC) for detailed description on controls
* or simple [Tutorial](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC-Tutorial)

### What available in [our sample](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples)

Simple copy of AntMedia sample app with all basic video call functions:

* Start/Stop Publishing WebRTC stream
* Start/Stop Playing WebRTC stream
* Init to preview from camera before start publishing
* Mute audio
* Mute video
* Switch camera
