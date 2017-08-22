<h1 align="center">EasyProviders Public Source Repository</h1>

**Provider initializer clean-template-library for Softwares**

* IMPORTANT! : This library was created from cropped source-code template from original source. Some code sections are left to be an example. :)

[What It Is](#what-it-is)

[How To Use](#how-to-use)

[About](#about)  

[Collaborators](#collaborators)  

[Branches](#branches) 

[Copyright & Licensing](#copyright--licensing)  

[Contributing](#contributing)  

[Contact](#contact)


## What It Is

**EasyProviders**

EasyProviders is an advanced provider/service control singleton-instanced library.

** Uses : .NET CORE 1.1 Class Library **

Controls and wizards are available for users to:

* Create as easy as possible custom provider service
* Control all providers/services with a single line of code.
* Boot/Shutdown your providers, analyze with StopWatch easily.
* Provide to great, compact, collective, regular manager-accessing in large projects & games etc...


## How To Use

Example Usage
=============

![Preview Thumbnail](https://raw.githubusercontent.com/Dentrax/EasyProviders/master/EasyProviders/Thumbnail.png)



Using Namespace
--------------------------
```
	using EasyProviders.Services;
	using EasyProviders.Services.Accessibility;
	using EasyProviders.Services.Advertising;
	using EasyProviders.Services.Analytics;
	using EasyProviders.Services.Audio;
	using EasyProviders.Services.Globalization;
	using EasyProviders.Services.Holiday;
	using EasyProviders.Services.Internationalization;
	using EasyProviders.Services.IO;
	using EasyProviders.Services.Multilingualization;
	using EasyProviders.Services.Personalization;
	using EasyProviders.Services.Social;
	using EasyProviders.Services.Storage;
	using EasyProviders.Services.Store;
	using EasyProviders.Services.Achievement;
	using EasyProviders.Services.Localization;
	using EasyProviders.Services.Notification;
```

Create GameServices Constructor
--------------------------
```
	GameServices SDK = new GameServices();
```

Create GameServices Initializer Dictionary
--------------------------
```
	Dictionary<ProviderType, ServiceProvider.InitializeContext> initDic = new Dictionary<ProviderType, ServiceProvider.InitializeContext>();
```

Insert Providers to GameServices Dictionary
--------------------------
```
	initDic.Add(ProviderType.Accessibility, new AccessibilityProvider.InitializeContext());
	initDic.Add(ProviderType.Achievement, new AchievementProvider.InitializeContext());
	initDic.Add(ProviderType.Advertising, new AdvertisingProvider.InitializeContext());
	initDic.Add(ProviderType.Analytics, new AnalyticsProvider.InitializeContext());
	initDic.Add(ProviderType.Audio, new AudioProvider.InitializeContext());
	initDic.Add(ProviderType.Globalization, new GlobalizationProvider.InitializeContext());
	initDic.Add(ProviderType.Holiday, new HolidayProvider.InitializeContext());
	initDic.Add(ProviderType.Internationalization, new InternationalizationProvider.InitializeContext());
	initDic.Add(ProviderType.IO, new IOProvider.InitializeContext());
	initDic.Add(ProviderType.Localization, new LocalizationProvider.InitializeContext());
	initDic.Add(ProviderType.Multilingualization, new MultilingualizationProvider.InitializeContext());
	initDic.Add(ProviderType.Notification, new NotificationProvider.InitializeContext());
	initDic.Add(ProviderType.Personalization, new PersonalizationProvider.InitializeContext());
	initDic.Add(ProviderType.Social, new SocialProvider.InitializeContext());
	initDic.Add(ProviderType.Storage, new StorageProvider.InitializeContext());
	initDic.Add(ProviderType.Store, new StoreProvider.InitializeContext());
```

Set Optional Functions
--------------------------
```
	SDK.SetSafeMode(false);
	SDK.SetDebugMode(false);
```

Initializing Providers (Call void Initialize() from all provides)
--------------------------
```
	SDK.Initialize(initDic);
```

Booting Providers (Call void Start() from all provides)
--------------------------
```
	SDK.Boot(delegate {
		//OnSuccess
	});
```

Shutting-down Providers (Call void Stop() from all provides)
--------------------------
```
	SDK.Shutdown(delegate {
		//OnSuccess
	});
```

## About

EasyProviders was created to serve three purposes:

**EasyProviders is a advanced providers/services/managers/singleton controller**

1. To act as a library to control providers/services/managers.

2. To provide a strong debugging, life-saver and advanced library for any bigger software & game project that requires a singleton/manager system architecture. 

3. Instead of writing long and complex code every time, it provides the easiest and strongest way.

## Collaborators

**Project Manager** - Furkan Türkal (GitHub: dentrax)

## Branches

We publish source for the **[EasyProviders]** in three rolling branches:

We publish source for the engine in three rolling branches:

The **[release branch](https://github.com/dentrax/EasyProviders/tree/release)** is extensively tested by our QA team and makes a great starting point for learning the EasyProviders.

The **[promoted branch](https://github.com/dentrax/EasyProviders/tree/promoted)** is updated with builds for our team members to use. It's a good balance between getting the latest cool stuff and knowing most things work.

The **[master branch](https://github.com/dentrax/EasyProviders/tree/master)** tracks [live changes](https://github.com/dentrax/EasyProviders/commits/master) by our EasyProviders team. 
This is the cutting edge and may be buggy - it may not even compile.

Other short-lived branches may pop-up from time to time as we stabilize new releases or hotfixes.

 ## Copyright & Licensing
 
The base project code is copyrighted by Furkan 'Dentrax' Türkal and is covered by single licence.

All program code (i.e. C#, Java) is licensed under GPL v3.0 unless otherwise specified. Please see the "LICENSE" file for more information.

## Contributing

Please check the [CONTRIBUTING.md](CONTRIBUTING.md) file for contribution instructions and naming guidelines.

## Contact

EasyProviders was created by Furkan 'Dentrax' Türkal

 * <https://www.furkanturkal.com>
 
You can contact EasyProviders by URL:
    **[CONTACT](https://github.com/dentrax)**
