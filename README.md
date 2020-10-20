# [DT](https://dreamteam-mobile.com/) Xamarin [Ant Media](https://antmedia.io/) WebRTC SDK Samples

This Repository contains Sample Apps for Xamarin Bindings of Ant Media WebRTC Android and iOS SDK's

Also we have **[WiKi](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki) with all detailed information and step-by-step Tutorials for easy usage of our [Nuget packages](https://www.nuget.org/packages?q=antmedia+dreamteammobile)**:

* for Xamarin Android [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Android/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Android/)
<br>this is a full binding on native Android Ant Media Free WebRTC SDK, same namespaces so you can use [Ant Media documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-Android-SDK-Documentation) for that nuget

* for Xamarin iOS [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.iOS/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.iOS/)
<br>this is a full binding on native iOS Ant Media Free WebRTC SDK, same namespaces so you can use [Ant Media documentation](https://github.com/ant-media/Ant-Media-Server/wiki/WebRTC-iOS-SDK-Guide) for that nuget

* for Xamarin Forms [![NuGet Package](https://buildstats.info/nuget/DT.Xamarin.AntMedia.WebRTC.Forms/)](https://www.nuget.org/packages/DT.Xamarin.AntMedia.WebRTC.Forms/)
<br>this is more complicated, we make forms package which have theis own classes and special for Forms usage, visit [our wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC) for details

## Code in Repository

### [Prerequisites](wiki/Prerequisites)
1. you need up running Ant Media Server, [detailed explanation here](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Prerequisites)

1. Start from **[DT.Xamarin.AntMedia.Samples.sln](DT.Xamarin.AntMedia.Samples.sln)**

1. replace constant to your server addres in **[DT.Configuration/InitialData.cs](DT.Configuration/InitialData.cs)**

```
public const string SERVER_ADDRESS = "domain-name.com:5080";
```

### Solution Projects

* [DT.Configuration](DT.Configuration) - Simple shared project, common constants

* [DT.WebRTC.Droid](DT.WebRTC.Droid) - Xamarin Android app with WebRTC sdk usage, [wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Android-WebRTC)

* [DT.WebRTC.iOS](DT.WebRTC.iOS) - Xamarin iOS app with WebRTC sdk usage, [wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-iOS-WebRTC)

* [DT.WebRTC.Forms](DT.WebRTC.Forms) - Xamarin Forms library with all UI and logic of app with our Forms WebRTC sdk usage, [wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

* [DT.WebRTC.Forms.Android](DT.WebRTC.Forms.Android) - Xamarin Forms Android app with our Forms WebRTC sdk usage, [wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

* [DT.WebRTC.Forms.iOS](DT.WebRTC.Forms.iOS) - Xamarin Forms iOS app with our Forms WebRTC sdk usage, [wiki](https://github.com/DreamTeamMobile/Xamarin.AntMedia.Samples/wiki/Xamarin-Forms-WebRTC)

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
