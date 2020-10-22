#### **CRITICAL thing about SDK** It Does Not Support Any Simulator build for now

# Xamarin Forms WebRTC Sample app

* [Documentation](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

* [Step by Step Tutorial](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC-Tutorial) how to add AntMedia WebRTC to Forms app

### [Prerequisites](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)
  you need up running Ant Media Server, [detailed explanation here](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)

### How to use nuget

* to all projects, Core, iOS, Android - add nuget package [DT.Xamarin.AntMedia.WebRTC.Forms](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/)

* to Android project - add nuget package [DT.Xamarin.AntMedia.WebRTC.Android](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/)

* to iOS project - add nuget package [DT.Xamarin.AntMedia.WebRTC.iOS](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/)

* add `[assembly: ExportRenderer(typeof(AntWebRTCView), typeof(AntWebRTCViewRenderer))]` to [AppDelegate.cs](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.WebRTC.Forms.iOS/AppDelegate.cs), outside of namespaces
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
* Configure Android Intent for Nuget
Open **Android/MainActivity.cs** Add code to **OnCreate**
```
       protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            //Begin Inserted
            DT.Xamarin.AntMedia.WebRTC.Forms.Android.AntAndroidService.CurrentIntent = Intent;
            //End Inserted

            global::Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
  ```
* add android and ios permissions usage

Modify Properties/AndroidManifest.xml
```
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android" android:versionCode="1" android:versionName="1.0" package="com.dreamteammobile.antmedia.dt_antmedia_tutorial_forms">
    <uses-sdk android:minSdkVersion="21" android:targetSdkVersion="28" />
    <application android:label="DT.AntMedia.Tutorial.Forms.Android" android:theme="@style/MainTheme"></application>
    <uses-feature android:name="android.hardware.camera" />
    <uses-feature android:name="android.hardware.camera.autofocus" />
    <uses-feature android:glEsVersion="0x00020000" android:required="true" />
    <uses-permission android:name="android.permission.CAMERA" />
    <uses-permission android:name="android.permission.CHANGE_NETWORK_STATE" />
    <uses-permission android:name="android.permission.MODIFY_AUDIO_SETTINGS" />
    <uses-permission android:name="android.permission.RECORD_AUDIO" />
    <uses-permission android:name="android.permission.BLUETOOTH" />
    <uses-permission android:name="android.permission.INTERNET" />
    <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
    <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
    <uses-permission android:name="android.permission.READ_PHONE_STATE" />
    <uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
</manifest>
```
add Camera and Microphone Permissions usage description to **Info.plist**
```
	<key>NSCameraUsageDescription</key>
	<string>Camera access is required for video chat</string>
	<key>NSMicrophoneUsageDescription</key>
	<string>Microphone access is required for video chat</string>
```
* add reference to framework on page or some view in Core project
  ```xaml
  xmlns:ant="clr-namespace:DT.Xamarin.AntMedia.WebRTC.Forms;assembly=DT.Xamarin.AntMedia.WebRTC.Forms"
  ```
  and use special control AntWebRTCView
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
  
  for more control on view, change **InitMode** property
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
  set server address and token(token can be empty string)
  ```
        AntFrame.Server = InitialData.SERVER_URL;
        AntFrame.Token = InitialData.Token;
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

1. Set Froms.Android or Forms.iOS project as Startup Project, click **Run** button in Visual Studio.
