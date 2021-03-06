﻿#region License
// ====================================================
// EasyProviders Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using System;
using System.Collections.Generic;

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

namespace EasyProviders.Example {

    public sealed class Program {

        static void Main(string[] args) {

            Console.Title = "EasyProviders";

            GameServices SDK = new GameServices();

            Dictionary<ProviderType, ServiceProvider.InitializeContext> initDic = new Dictionary<ProviderType, ServiceProvider.InitializeContext>();
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

            SDK.SetSafeMode(false);
            SDK.SetDebugMode(false);

            SDK.Initialize(initDic);

            SDK.Boot(delegate (bool success) {

                if (success) {
                    Console.WriteLine("EasyProviders SDK booted successfully!");
                } else {
                    Console.WriteLine("EasyProviders get an error while booting SDK!");
                }

                Console.WriteLine("Safe mode enabled : " + SDK.IsSafeModeEnabled);

            });

            Console.WriteLine();

            SDK.Globalization.Test();

            Console.WriteLine();

            SDK.Shutdown(delegate (bool success) {

                if (success) {
                    Console.WriteLine("EasyProviders SDK shutdown success!");
                } else {
                    Console.WriteLine("EasyProviders get an error while while shutting-down SDK!");
                }
                
            });

            Console.ReadLine();
        }
    }
}