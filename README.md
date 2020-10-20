# [DT](https://dreamteam-mobile.com/) Xamarin [Ant Media](https://antmedia.io/) WebRTC SDK Samples

This Repository contains Sample Apps for Nuget Bindings of Ant Media WebRTC Android and iOS SDK's from Dreamteam Mobile

Also we made Tutorials and [WiKi](wiki) for easy usage of our packages

* Xamarin Android [![NuGet Packege](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/)
<br>this is a full binding on native Android Ant Media Free WebRTC SDK, same namespaces so you can use [Ant Media documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-Android-SDK-Documentation) for that nuget

* Xamarin iOS [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/)
<br>this is a full binding on native iOS Ant Media Free WebRTC SDK, same namespaces so you can use [Ant Media documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-iOS-SDK-Guide) for that nuget

* Xamarin Forms [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/)
<br>this is more complicated, we make forms package which have theis own classes and special for Forms usage, visit [our wiki](wiki/Xamarin-Forms-WebRTC) for details

## Code in Repository

### [Prerequisites](wiki/Prerequisites)
1. you need up running Ant Media Server, [detailed explanation here](wiki/Prerequisites)

1. Start from **[DT.Xamarin.AntMedia.Samples.sln](DT.Xamarin.AntMedia.Samples.sln)**

1. replace constant to your server addres in **[DT.Configuration/InitialData.cs](DT.Configuration/InitialData.cs)**

```
public const string SERVER_ADDRESS = "domain-name.com:5080";
```

### Solution Projects

* DT.Configuration - Simple shared project, common constants

* DT.WebRTC.Droid - Xamarin Android app with WebRTC sdk usage

* DT.WebRTC.iOS - Xamarin Android app with WebRTC sdk usage

* DT.WebRTC.Forms - Xamarin Forms Android app with our Forms WebRTC sdk usage

* DT.WebRTC.Forms.Android - Xamarin Forms Android app with our Forms WebRTC sdk usage

* DT.WebRTC.Forms.iOS - Xamarin Forms iOS app with our Forms WebRTC sdk usage

## License
The MIT License (MIT).

## Contact
contact@dreamteam-mobile.com

https://dreamteam-mobile.com/

* We work with platforms: iOS, Android and web.
* We develop event apps, business apps, games, apps for internal distribution, apps for App Store, Google Play.
* We know how to build single apps, app ecosystems and complete integrated solutions (that include API, Admin panel and a mobile app or apps).
* We have knowledge and experience with the following business domains: audio calls and video calls, VOIP apps, navigation and mapping apps, geolocation-based apps, translators, business (B2C) apps, messengers, ticketings systems and many many more.
* We use the tools you want: Swift/Objective-C, Kotlin/Java, Xamarin, ReactNative, Flutter, Ionic
