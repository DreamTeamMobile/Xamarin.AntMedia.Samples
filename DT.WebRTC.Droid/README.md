# Xamarin Android WebRTC [Sample app](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples)

### [Prerequisites](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)
  you need up running Ant Media Server, [detailed explanation here](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)

### How to use nuget

* add nuget package [DT.Xamarin.AntMedia.WebRTC.Android](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/) [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/)
<br>no additional steps required to init that package, all namespaces are equal to original framework

* then you can use 
  * our [Step by Step Xamarin Tutorial](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Android-WebRTC-Tutorial) to Create app
  * [Ant Media iOS Sample documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-Android-SDK-Documentation)
  
### What in sample

Simple copy of AntMedia sample app with all basic video call functions:

* Start/Stop Publishing WebRTC stream
* Start/Stop Playing WebRTC stream
* Init to preview from camera before start publishing
* Mute audio
* Mute video
* Switch camera

### How to Run Sample

1. Start from **[..DT.Xamarin.AntMedia.Samples.sln](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.Xamarin.AntMedia.Samples.sln)**

1. replace constant to your server addres in **[..DT.Configuration/InitialData.cs](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/blob/main/DT.Configuration/InitialData.cs)**

```
public const string SERVER_ADDRESS = "domain-name.com:5080";
```

1. click **Run** button in Visual Studio.
