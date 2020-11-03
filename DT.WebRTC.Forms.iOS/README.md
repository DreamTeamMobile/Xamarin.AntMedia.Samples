# Xamarin Forms WebRTC [Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples), iOS project

* [Documentation](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

* [Step by Step Tutorial](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC-Tutorial) create WebRTC Forms app


### [Prerequisites](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)
  you need up running Ant Media Server, [detailed explanation here](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)

### How to use nuget

* to all projects, Core, iOS, Android - add nuget package [DT.Xamarin.AntMedia.WebRTC.Forms](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/)

* to iOS project - add nuget package [DT.Xamarin.AntMedia.WebRTC.iOS](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/)


* add `AntManagerIos.Init();` to [AppDelegate.cs](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.WebRTC.Forms.iOS/AppDelegate.cs)
  ```
	public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AntManagerIos.Init();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
  ...
  ```
* add Camera and Microphone Permissions usage description to **Info.plist**
  ```
	  <key>NSCameraUsageDescription</key>
	  <string>Camera access is required for video chat</string>
	  <key>NSMicrophoneUsageDescription</key>
	  <string>Microphone access is required for video chat</string>
  ```
* use special control AntWebRTCView
  ```
  <?xml version="1.0" encoding="utf-8"?>
  <ContentPage
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:ant="clr-namespace:DT.Xamarin.AntMedia.WebRTC.Forms;assembly=DT.Xamarin.AntMedia.WebRTC.Forms"
    x:Class="DT.AntMedia.Tutorial.Forms.MainPage">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition/>
        </Grid.RowDefinitions>
        <ant:AntWebRTCView
            x:Name="AntFrame1"
            Grid.Row="0"
            Server="ws://drmtm.us:5080/WebRTCAppEE/websocket"
            RenderingMode="ScaleAspectFit"
            WebRTCMode="Publish"
            Camera="Front"
            StreamID="stream1"
            ShowDebugLogs="True"
            InitMode="InitAndStartOnViewRender"
            />

        <ant:AntWebRTCView
            x:Name="AntFrame2"
            Grid.Row="1"
            Server="ws://drmtm.us:5080/WebRTCAppEE/websocket"
            RenderingMode="ScaleAspectFit"
            WebRTCMode="Play"
            StreamID="stream2"
            ShowDebugLogs="True"
            InitMode="InitAndStartOnViewRender"
            />
    </Grid>
  </ContentPage>
  ```
  You done! run and check

* then you can use our [Documentation](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC) for detailed description on controls
* or simple [Tutorial](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC-Tutorial)

### What available in [our sample](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples)

Simple copy of AntMedia sample app with all basic video call functions:

* Start/Stop Publishing WebRTC stream
* Start/Stop Playing WebRTC stream
* Init to preview from camera before start publishing
* Mute audio
* Mute video
* Switch camera

### How to Run Sample

1. Start from **[DT.Xamarin.AntMedia.Samples.sln](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.Xamarin.AntMedia.Samples.sln)**

1. replace constant to your server addres in **[DT.Configuration/InitialData.cs](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.Configuration/InitialData.cs)**

```
public const string SERVER_ADDRESS = "domain-name.com:5080";
```

1. Set Forms.iOS as Startup project, click **Run** button in Visual Studio.
