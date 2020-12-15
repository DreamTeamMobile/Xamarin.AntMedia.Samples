![](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/raw/main/AntMedia-Banner.jpg)
# Glad to introduce [Ant Media](https://antmedia.io/) Mobile SDK Xamarin Bindings
Time to read: 20 min.
What you will get from reading this post:
* What is AntMedia WebRTC SDK
* Where to get samples, documentation and help on using of SDK
* How to easy use it on Xamarin Forms
* How to easy use it on Xamarin Android
* How to easy use it on Xamarin iOS

### Small Hint
All information about Ant Media Server available on creators [Ant Media wiki here](https://github.com/ant-media/Ant-Media-Server/wiki)
We are an independent team and we are not related to Ant Media, we just like to do Xamarin bindings to different native frameworks.

## Where to get Nugets

We release packages with simple samples for them on Xamarin:

* Ant Media WebRTC for Xamarin Android [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/)

  this is a full binding on native Android Ant Media Free WebRTC SDK, same namespaces so you can use [Ant Media documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-Android-SDK-Documentation) for that nuget

* Ant Media WebRTC for Xamarin iOS [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/)

  this is a full binding on native iOS Ant Media Free WebRTC SDK, same namespaces so you can use [Ant Media documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-iOS-SDK-Guide) for that nuget

* Ant Media WebRTC for Xamarin Forms [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/)

  this is more complicated, we make forms package which have theis own classes and special for Forms usage, visit [our wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC) for full description

## What is [Ant Media Server](https://github.com/ant-media/Ant-Media-Server/wiki)
Ant Media Server is a software that can stream live and VoD streams. It supports scalable, ultra low latency (0.5 seconds) adaptive streaming and records live videos in several formats like HLS, MP4, etc.

Here are the fundamental features of Ant Media Server:

* Ultra Low Latency Adaptive One to Many WebRTC Live Streaming in Enterprise Edition.
* Adaptive Bitrate for Live Streams (WebRTC, MP4, HLS) in Enterprise Edition.
* SFU in One to Many WebRTC Streams in Enterprise Edition.
* Live Stream Publishing with RTMP and WebRTC.
* WebRTC to RTMP Adapter.
* IP Camera Support.
* Recording Live Streams (MP4 and HLS).
* Restream to Social Media Simultaneously(Facebook and Youtube in Enterprise Edition).
* One-Time Token Control in Enterprise Edition.
* Object Detection in Enterprise Edition.
* H.264,H.265 and VP8 
* WebRTC Data Channels

## Mobile SDKs is Free but Server has Community Edition & Enterprise Edition
Ant Media Server has two versions. One of them is the Community Edition(Free) and the other one is Enterprise Edition. Community Edition is available to [download on Github.](https://github.com/ant-media/Ant-Media-Server)
Enterprise Edition can be purchased [on antmedia.io](https://antmedia.io) 


|      | Community Edition  | Enterprise Edition |
| :---         |     :---:      | :---: |
| Ultra Low Latency One-to-Many WebRTC Streaming    | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| End-to-End Latency     | 8-12 Seconds  | 0.5 Seconds (500ms)  |
| Scaling  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| RTMP(Ingesting) to WebRTC (Playing)  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Hardware Encoding(GPU)  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Adaptive Bitrate  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Secure Streaming  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| iOS & Android RTMP SDK  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| iOS & Android WebRTC SDK  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| VP8 and H.265 Support  | ![false](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/false-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| JavaScript SDK  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| RTMP, RTSP, MP4 and HLS Support  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| WebRTC to RTMP Adapter  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| 360 Degree Live & VoD Streams  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Web Management Dashboard  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| IP Camera Support  | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Re-stream Remote Streams | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Open Source | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Simulcast to all Social Media via RTMP | ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |  ![true](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/true-icon.png)  |
| Support |  Community |  E-mail, On-site  |
| Price |  Free |  Paid  |

## Prerequisites
To start any work with Ant Media Mobile SDKs you need AntMedia Server in web, how to setup that server described in [Ant Media Documentation](https://github.com/ant-media/Ant-Media-Server/wiki)

if you have server on some domain address **we recommend valid ssl certificate on domain to start work**

```
domain-name.com:5080
```
Typical URLs to work in SDK:
```      
public const string SERVER_ADDRESS = "domain-name.com:5080";
public const string SERVER_URL = "ws://" + SERVER_ADDRESS + "/WebRTCAppEE/websocket";
public const string REST_URL = "https://" + SERVER_ADDRESS + "/WebRTCAppEE/rest/v2";
```

Ant Media Server has samples for demonstrating different use-cases. You can review these sample pages to see Ant Media Server in action.

Default applications in Enterprise Edition are `LiveApp` and `WebRTCAppEE`.  Default applications in Community Edition are `LiveApp` and `WebRTCApp`. 

You can publish a video with WebRTC from the following URL.
````
https://domain-name.com:5443/WebRTCAppEE
````
for playing form is available **in Enterprise Edition**
````
https://domain-name.com:5443/WebRTCAppEE/player.html
````

[Here you can find all most usable links on a server with description](https://github.com/ant-media/Ant-Media-Server/wiki/Sample-List)

## Keep in mind
AntMedia WebRTC SDK can:
* play streams and publish streams.
* 1 WebRTCClient is just a 1 connection, usually every video on a screen is 1 WebRTCClient
* WebRTCClient have Mode, it can be Join, Play, Publish
  * Play - client play and render 1 stream to 1 view
  * Publish - client publish and render 1 stream to 1 view, it can be video from camera or sreensharing
  * Join - in 1 connection 2 streams, incoming and outgoing - typical for 1 to 1 calls. In that mode you set 2 views and client rendering to them incoming and outgoing streams, outgoing stream you start manually so can control
* Data channel inside webRTC connection allow you to send from 1 user to all connected participants binary or text message, just enable DataChannel on server and on clients Init.
  

## Xamarin Android usage
short list if useful links:
* [Android Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/tree/main/DT.WebRTC.Droid)
* [Native Ant Media Android Sample documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-Android-SDK-Documentation)
* our [Wiki and Step by Step Xamarin Android Tutorial on Github](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Android-WebRTC)

Ok, now if you want to use cool video streaming in your app follow this steps.

* Add nuget package [DT.Xamarin.AntMedia.WebRTC.Android](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/) to your project
![add DT.Xamarin.AntMedia.WebRTC.Android to DT.AntMedia.WebRTC.Android](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/AndroidTutorial/Screenshot5.png)
* Modify Properties/AndroidManifest.xml (Add permissions)
```
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android" android:versionCode="1" android:versionName="1.0" package="com.dreamteammobile.antmedia.dt_antmedia_webrtc_android">
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
* add view to XML layout
```xml
<?xml version="1.0" encoding="utf-8"?>
<FrameLayout xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:app="http://schemas.android.com/apk/res-auto"
    xmlns:tools="http://schemas.android.com/tools"
    android:layout_width="match_parent"
    android:layout_height="match_parent"
    tools:context=".MainActivity">

    <org.webrtc.SurfaceViewRenderer
        android:id="@+id/camera_view_renderer"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:layout_gravity="center" />

    <FrameLayout
        android:id="@+id/call_fragment_container"
        android:layout_width="match_parent"
        android:layout_height="match_parent" /> 
</FrameLayout>
```
* in your Activity add code to init WebRTCClient and start streaming. You should add `SERVER_URL` according to your Ant Media Server address. Secondly, the third parameter in the last line of the code below is `WebRTCClientConsts.ModePublish` that publishes the stream to the server. You can use `WebRTCClientConsts.ModeJoin` for playing stream and `WebRTCClientConsts.ModeJoin` for P2P communication. If token control is enabled, you should define `tokenId` parameter.
```csharp
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity, IWebRTCListener
    {
        /**
         * Mode can Publish, Play or P2P
         */
        private String webRTCMode = WebRTCClientConsts.ModePlay;
        private CallFragment callFragment;
        
        private WebRTCClient webRTCClient;

        private Timer timer;
        private String SERVER_URL = "ws://192.168.1.21:5080/WebRTCAppEE/websocket";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set window styles for fullscreen-window size. Needs to be done before
            // adding content.
            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.KeepScreenOn
                    | WindowManagerFlags.DismissKeyguard | WindowManagerFlags.ShowWhenLocked
                    | WindowManagerFlags.TurnScreenOn);
            SetContentView(Resource.Layout.activity_main);
            
            // Check for mandatory permissions.
            foreach (String permission in CallActivity.MandatoryPermissions)
            {
                if (this.CheckCallingOrSelfPermission(permission) != Andr.Content.PM.Permission.Granted)
                {
                    Toast.MakeText(this, "Permission " + permission + " is not granted", ToastLength.Short).Show();
                    return;
                }
            }
            //Init and start AntMedia
            InitWebRTC();
        }

        protected void InitWebRTC()
        {
            if(webRTCClient != null)
            {
                webRTCClient.StopStream();
                webRTCClient.Disconnect();
                webRTCClient.Dispose();
            }
            webRTCClient = new WebRTCClient(this, this);
            //configure
            Intent.PutExtra(CallActivity.ExtraCapturetotextureEnabled, true);
            Intent.PutExtra(CallActivity.ExtraVideoFps, 30);
            Intent.PutExtra(CallActivity.ExtraVideoBitrate, 2500);
            Intent.PutExtra(CallActivity.ExtraCapturetotextureEnabled, true);
            SurfaceViewRenderer cameraViewRenderer = FindViewById<SurfaceViewRenderer>(Resource.Id.camera_view_renderer);
            SurfaceViewRenderer pipViewRenderer = FindViewById<SurfaceViewRenderer>(Resource.Id.pip_view_renderer);
            var streamId = "DefaultStream";
            var tokenId = "";
            webRTCClient.SetVideoRenderers(null, cameraViewRenderer);
            webRTCClient.SetOpenFrontCamera(webRTCMode.Equals(WebRTCClientConsts.ModePublish));
            webRTCClient.Init(SERVER_URL, streamId, webRTCMode, tokenId, Intent);
            //start
            webRTCClient.StartStream();
        }
   }
```
* WebRTCClient usage hints
```java
     
void WebRTCClient.setOpenFrontCamera(boolean openFrontCamera)

      Camera open order
      By default front camera is attempted to be opened at first,
      if it is set to false, another camera that is not front will be tried to be open
      @param openFrontCamera if it is true, the front camera will be tried to be opened
                             if it is false, another camera that is not front will be tried to be opened
```

```java

void WebRTCClient.startStream()
  
      Starts the streaming according to the mode

```

```java

void WebRTCClient.stopStream()

      Stops the streaming

```

```java

void WebRTCClient.switchCamera()

      Switches the cameras

```

```java

void WebRTCClient.switchVideoScaling(RendererCommon.ScalingType scalingType)

      Switches the video according to type and its aspect ratio
      @param scalingType

```

```java

boolean WebRTCClient.toggleMic()

      toggle microphone
      @return Microphone Current Status (boolean)

```

```java

void WebRTCClient.stopVideoSource()

      Stops the video source, it can be camera or screen share. oponent will not receive video stream and will see just a black rectangle.

```

```java

void WebRTCClient.startVideoSource()

      Starts or restarts the video source

```

```java

void WebRTCClient.setSwappedFeeds(boolean b)

      Swapped the fullscreen renderer and pip renderer, used only for Join(P2P) mode when 2 streams per 1 connection
      @param b

```

```java

void WebRTCClient.setVideoRenderers(SurfaceViewRenderer pipRenderer, SurfaceViewRenderer fullscreenRenderer)

      Set's the video renderers,
      @param pipRenderer can be nullable, for Play and Publish you don't need to set it to something, for Join mode please set to view where you want to render your stream
      @param fullscreenRenderer cannot be nullable, rendering one stream for Play mode or Publish mode, and rendering opponent stream for Join(P2P) mode

```
that's all! you can now make Android apps with AntMedia streaming, here you ca find sources of simple [Android Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/tree/main/DT.WebRTC.Droid)

## Xamarin iOS usage
short list if useful links:
* [iOS Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/tree/main/DT.WebRTC.iOS)
* [Native Ant Media Android Sample documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-iOS-SDK-Guide)
* our [Wiki and Step by Step Xamarin iOS Tutorial on Github](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-iOS-WebRTC)

Steps to run in your solution and hints:

Add nuget package [DT.Xamarin.AntMedia.WebRTC.iOS](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/) to project

![add DT.Xamarin.AntMedia.WebRTC.iOS to DT.AntMedia.WebRTC.iOS](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/iOSTutorial/Screenshot5.png)

### Add iOS permissions to Info.plist
```
	<key>NSCameraUsageDescription</key>
	<string>Camera access is required for video chat</string>
	<key>NSMicrophoneUsageDescription</key>
	<string>Microphone access is required for video chat</string>
```
add Camera and Microphone Permissions usage description to **Info.plist**

![iOS permissions](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/iOSTutorial/Screenshot6.png)

### add view to layout
Add UIView with specified size or constraints to **Your.storyboard** or create UIView from code behind

### in your ViewController add code
to init AntMediaClient and start streaming. You should add `SERVER_URL` according to your Ant Media Server address. Secondly, the third parameter in the last line of the code below is `AntMediaClientMode.Publish` that publishes the stream to the server. You can use `AntMediaClientMode.Play` for playing stream and `AntMediaClientMode.Join` for P2P communication. If token control is enabled, you should define `tokenId` parameter. dataChannelEnabled parameter allow send data messages throw WebRTC client between connected users if set to "true".
```csharp
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
            var token = "";
            var streamId = "stream1";
            webRtcClient.SetOptionsWithUrl(SERVER_URL, streamId, token, clientMode, enableDataChannel: true);

            switch (clientMode)
            {
                case AntMediaClientMode.Play:
                    webRtcClient.SetRemoteViewWithRemoteContainer(fullscreen_UIView, UIViewContentMode.ScaleAspectFit);
                    break;
                case AntMediaClientMode.Publish:
                    webRtcClient.SetCameraPositionWithPosition(AVFoundation.AVCaptureDevicePosition.Front);
                    webRtcClient.SetLocalViewWithContainer(fullscreen_UIView, UIViewContentMode.ScaleAspectFit);
                    webRtcClient.SetVideoEnableWithEnable(true);
                    break;
                case AntMediaClientMode.Join:
                    var small = new UIView(new CoreGraphics.CGRect(0, 0, 160, 240));
                    secondaryHeight.Constant = 240;
                    secondaryContainer.AddSubview(small_pip_UIView);
                    webRtcClient.SetLocalViewWithContainer(small_pip_UIView, UIViewContentMode.ScaleAspectFit);
                    webRtcClient.SetRemoteViewWithRemoteContainer(fullscreen_UIView, UIViewContentMode.ScaleAspectFit);
                    break;
            }

            webRtcClient.InitPeerConnection();
            webRtcClient.Start();
        }
   }
```
### AntMediaClient usage hints

```csharp
     
void AntMediaClient.SetCameraPositionWithPosition(AVFoundation.AVCaptureDevicePosition position);

      change Current Camera to front or back
      @param position is enum contains Front or Back camera value
```

```csharp

void AntMediaClient.Start()
  
      Starts the streaming according to the mode

```

```csharp

void AntMediaClient.Stop()

      Stops the streaming

```

```csharp

void AntMediaClient.SwitchCamera()

      Switches the cameras

```

```csharp

void AntMediaClient.ToggleAudio()

      toggle microphone
      
```

```csharp

void AntMediaClient.ToggleVideo()

      toggle video mute, if muted - no video data sending, black rectangle will be renderred
      
```

```csharp

void AntMediaClient.SetLocalViewWithContainer(UIVIew view, UIViewContentMode mode);

      Used to set view for rendering local video stream from user camera
      @param view - UIView for rendering
      #param mode - content rendering mode, Fill, AspectFit and others.

```

```csharp

void AntMediaClient.SetRemoteViewWithRemoteContainer(UIVIew view, UIViewContentMode mode);

      Used to set view for rendering oponent stream video (received from network stream)
      @param view - UIView for rendering
      #param mode - content rendering mode, Fill, AspectFit and others.

```

Also there is IAntMediaClientDelegate interface, which contains events you can handle (connect, disconnect, error) most interesting is receive data-message event, here how you can handle it to show message

```csharp

public void DataReceivedFromDataChannelWithStreamId(string streamId, NSData data, bool binary)
        {
            BeginInvokeOnMainThread(() =>
            {
                var controller = UIAlertController.Create("DataReceived on " + streamId, data.ToString(NSStringEncoding.UTF8), UIAlertControllerStyle.Alert);
                controller.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Destructive, null));
                PresentViewController(controller, true, null);
            });
        }
        
```
that's all! you can now make iOS apps with AntMedia streaming, here you ca find sources of simple [iOS Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/tree/main/DT.WebRTC.iOS)

## Xamarin Forms usage
short list if useful links:
* [iOS Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/tree/main/DT.WebRTC.iOS)
* our [Wiki and Step by Step Xamarin Forms Tutorial on Github](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

Steps to run in your solution and hints:

### Add Forms WebRTC SDK Nuget package

Add nuget package [DT.Xamarin.AntMedia.WebRTC.Forms](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/) to Forms core project

![](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/FormsTutorial/Screenshot5.png)

### Configure iOS

Add `AntManagerIos.Init();` to **AppDelegate.cs**
```
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
   AntManagerIos.Init();
   global::Xamarin.Forms.Forms.Init();
   LoadApplication(new App());
   return base.FinishedLaunching(app, options);
}
```

Add iOS permissions to **Info.plist**
```
	<key>NSCameraUsageDescription</key>
	<string>Camera access is required for video chat</string>
	<key>NSMicrophoneUsageDescription</key>
	<string>Microphone access is required for video chat</string>
```
add Camera and Microphone Permissions usage description to **Info.plist**

![iOS permissions](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/images/FormsTutorial/Screenshot8.png)

### Configure Android
Open **MainActivity.cs** Add code to **OnCreate**
```
protected override void OnCreate(Bundle savedInstanceState)
{
    TabLayoutResource = Resource.Layout.Tabbar;
    ToolbarResource = Resource.Layout.Toolbar;

    base.OnCreate(savedInstanceState);

    //Begining of Inserted
    AntManagerDroid.Init(Intent);
    //End of Inserted

    global::Xamarin.Essentials.Platform.Init(this, savedInstanceState);
    global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
    LoadApplication(new App());
}
```

Modify permissions for Android project, Properties/AndroidManifest.xml
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
### Finally modify Forms Core shared code

Now we ready to Add ant:AntWebRTCView to a page, will use from xaml but you can easy create same from code behind

add reference to framework on page xaml
```xaml
  xmlns:ant="clr-namespace:DT.Xamarin.AntMedia.WebRTC.Forms;assembly=DT.Xamarin.AntMedia.WebRTC.Forms"
```
  and use special control ant:AntWebRTCView, we Adding 2 - for Playing and for Publishing, typical One to One call app, if you need more - add more **AntWebRTCView** to your layout **WebRTCMode** is configuring what view will do, publish or play stream
```xaml
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
            RenderingMode="ScaleAspectFit"
            WebRTCMode="Play"
            StreamID="stream2"
            ShowDebugLogs="True"
            InitMode="InitAndStartOnViewRender"
            />
    </Grid>
  </ContentPage>
```
  
Add to Code Behind stream url and token
```csharp
  
public partial class MainPage : ContentPage
{
   public MainPage()
   {
      InitializeComponent();
      AntManager.Current.DefaultServer = InitialData.SERVER_URL;
      AntManager.Current.DefaultToken = InitialData.Token;
   }
```
and that is all! Because, if you use simply form and InitMode="InitAndStartOnViewRender" for AntWebRTCView - you can run app and all start-stop and init native events was called on create and on leave page, but you still can Stop manually by calling AntWebRTCView.Stop();

### Forms usage hints

**AntWebRTCView** - view that control 1 webrtc connection, that view is an extended interface to get all functionality of native AntMediaClient (iOS) and WebRTCClient (Android)

```
bool AntWebRTCView.EnableDataChannel

  set this property to enable messages throw data channel fro current user
```

```csharp

void AntWebRTCView.Init()
  
      Init connection and start preview from camera into view if in publish mode.

```

```csharp

void AntWebRTCView.Start()
  
      Starts the streaming according to the mode

```

```csharp

void AntWebRTCView.Stop()

      Stops the streaming

```

```csharp

void AntWebRTCView.SwitchCamera()

      Switches the cameras

```

```csharp

void AntWebRTCView.ToggleAudio()

      toggle microphone
      
```

```csharp

void AntWebRTCView.ToggleVideo()

      toggle video mute, if muted - no video data sending, black rectangle will be renderred
      
```

**AntManager** - singletone, manager class for all created clients and connections, you can setup default values for server url, token and then override them in AntWebRTCView if you need.
also AntManager can give you access to all native events of android and iOS, for example
```
//subscribe to receive message with exact AntWebRTCView ad it's webrtc connection on all platforms
AntFrame.DataReceived += AntFrame_DataReceived; 

//subscribing to receive message on iOS from all active webrtc connections
AntManager.Current.Ios_IAntMediaClientDelegate_DataReceivedFromDataChannelWithStreamId += Current_Ios_IAntMediaClientDelegate_DataReceivedFromDataChannelWithStreamId;

//subscribing to receive message on Android from all active webrtc connections
AntManager.Current.Android_IDataChannelObserver_OnMessage += Instance_Android_IDataChannelObserver_OnMessage;
```

sample of handling incoming data-message
```
private void AntFrame_DataReceived(object sender, DataEventArgs e)
{
    //receive for all Platforms message routed from AntView by special StreamId
    Dispatcher.BeginInvokeOnMainThread(async () =>
    {
        await DisplayAlert("DataReceived", e.IsBinary ? "[Binary]" : e.Message, "ОK");
    });
}
```

### AntWebRTCView.InitMode

**Manually** - means that developer need to call Init() and Start(), Stop() methods manually from code

**InitOnViewRender** - most common cases need to use this mode - init of view happens on create, that means in publish mode picture start rendering from camera just when it's renderred on screen. Start() and Stop() should be called manualy from code behind

**InitAndStartOnViewRender** - 100% automatically mode, start publshing or playing when view renderred. code behind needed to stop and restart only.

all variants of usages for AntWebRTCView you can find in [Documentation](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/AntWebRTCView)

that's all! you can now make Android, iOS, Forms-Android and Forms-iOS apps with AntMedia streaming SDK, here you can look to extended sources of simple [Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples), it contains Android, iOS and Forms apps.


