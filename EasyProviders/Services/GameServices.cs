using System;
using System.Linq;
using System.Collections.Generic;
using EasyProviders.Services.Accessibility;
using EasyProviders.Services.Achievement;
using EasyProviders.Services.Advertising;
using EasyProviders.Services.Analytics;
using EasyProviders.Services.Audio;
using EasyProviders.Services.Globalization;
using EasyProviders.Services.Holiday;
using EasyProviders.Services.Internationalization;
using EasyProviders.Services.IO;
using EasyProviders.Services.Localization;
using EasyProviders.Services.Notification;
using EasyProviders.Services.Multilingualization;
using EasyProviders.Services.Personalization;
using EasyProviders.Services.Social;
using EasyProviders.Services.Storage;
using EasyProviders.Services.Store;

namespace EasyProviders.Services {
    public sealed class GameServices {

        private Dictionary<ProviderType, IServiceProvider> m_services = new Dictionary<ProviderType, IServiceProvider>();

        public bool WasInitialized { get; private set; }

        public bool IsBooted { get; private set; }

        public bool IsSafeModeEnabled { get; private set; }

        public GameServices() {
            this.WasInitialized = false;
            this.IsBooted = false;
            this.IsSafeModeEnabled = false;

            this.m_services.Add(ProviderType.Accessibility, new AccessibilityProvider());
            this.m_services.Add(ProviderType.Achievement, new AchievementProvider());
            this.m_services.Add(ProviderType.Advertising, new AdvertisingProvider());
            this.m_services.Add(ProviderType.Analytics, new AnalyticsProvider());
            this.m_services.Add(ProviderType.Audio, new AudioProvider());
            //Award
            //Device
            this.m_services.Add(ProviderType.Globalization, new GlobalizationProvider());
            //Graphic
            this.m_services.Add(ProviderType.Holiday, new HolidayProvider());
            this.m_services.Add(ProviderType.Internationalization, new InternationalizationProvider());
            this.m_services.Add(ProviderType.IO, new IOProvider());
            this.m_services.Add(ProviderType.Localization, new LocalizationProvider());
            this.m_services.Add(ProviderType.Multilingualization, new MultilingualizationProvider());
            //Network
            this.m_services.Add(ProviderType.Notification, new NotificationProvider());
            this.m_services.Add(ProviderType.Personalization, new PersonalizationProvider());
            this.m_services.Add(ProviderType.Social, new SocialProvider());
            this.m_services.Add(ProviderType.Storage, new StorageProvider());
            this.m_services.Add(ProviderType.Store, new StoreProvider());
        }

        public void Initialize(Dictionary<ProviderType, ServiceProvider.InitializeContext> initDict) {
            if (this.WasInitialized) {
                throw new Exception("[GameServices::Initialize()] -> GameServices already initialized");
            }

            if (m_services.Count != initDict.Count) {
                throw new Exception("[GameServices::Initialize()] -> m_service count != initDict count");
            }

            if (!m_services.Keys.SequenceEqual(initDict.Keys)) {
                throw new Exception("[GameServices::Initialize()] -> Keys are not sequential equal");
            }

            foreach (KeyValuePair<ProviderType, ServiceProvider.InitializeContext> init in initDict) {
                if (this.m_services.Count <= 0) {
                    throw new Exception("[GameServices::Initialize()] -> Service list is empty");
                }
                if (!this.IsServiceListContains(init.Key)) {
                    throw new Exception("[GameServices::Initialize()] -> Service list not contains : " + init.Key);
                } 
                if (init.Value == null) {
                    throw new Exception("[GameServices::Initialize()] -> Null init value received : " + init.Key);
                }

                this.m_services[init.Key].Initialize(init.Value);
            }

            this.WasInitialized = true;
        }

        public void Boot(Action onDone = null) {
            if (!this.WasInitialized) {
                throw new Exception("[GameServices::Boot()] -> You should initialize first!");
            }

            if (this.IsBooted) {
                throw new Exception("[GameServices::Boot()] -> GameServices already booted!");
            }

            ProviderLocator<ProviderType>.Boot(m_services, delegate {
                this.IsBooted = true;
                if (onDone != null) onDone();
            });
        }

        public void Shutdown(Action onDone = null) {
            if (!this.WasInitialized) {
                throw new Exception("[GameServices::Boot()] -> You should initialize first!");
            }

            if (!this.IsBooted) {
                throw new Exception("[GameServices::Boot()] -> You should boot GameServices first!");
            }

            ProviderLocator<ProviderType>.Shutdown(m_services, delegate {
                this.IsBooted = false;
                if (onDone != null) onDone();
            });
        }

        public bool IsAllServicesStarted() {
            foreach (KeyValuePair<ProviderType, IServiceProvider> service in m_services) {
                if (!service.Value.IsStarted) {
                    return false;
                }
            }
            return true;
        }

        private bool IsServiceListContains(ProviderType provider) {
            return this.m_services.ContainsKey(provider);
        }

        public void SetSafeMode(bool mode) {
            this.IsSafeModeEnabled = mode;
        }

        public AccessibilityProvider Accessibility {
            get {
                if(!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<AccessibilityProvider>(ProviderType.Accessibility);
            }
        }

        public AchievementProvider Achievement {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<AchievementProvider>(ProviderType.Achievement);
            }
        }

        public AdvertisingProvider Advertising {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<AdvertisingProvider>(ProviderType.Advertising);
            }
           
        }

        public AnalyticsProvider Analytics {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<AnalyticsProvider>(ProviderType.Analytics);
            }
        } 

        public AudioProvider Audio {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<AudioProvider>(ProviderType.Audio);
            }
        }

        //Award
        //Device

        public GlobalizationProvider Globalization {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<GlobalizationProvider>(ProviderType.Globalization);
            }
        }

        //Graphic

        public HolidayProvider Holiday {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<HolidayProvider>(ProviderType.Holiday);
            }
        }

        public InternationalizationProvider Internationalization {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<InternationalizationProvider>(ProviderType.Internationalization);
            }
        }

        public IOProvider IO {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<IOProvider>(ProviderType.IO);
            }
        }

        public LocalizationProvider Localization {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<LocalizationProvider>(ProviderType.Localization);
            }
        }

        public MultilingualizationProvider Multilingualization {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<MultilingualizationProvider>(ProviderType.Multilingualization);
            }
        }

        //Network
        public NotificationProvider Notification {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<NotificationProvider>(ProviderType.Notification);
            }
        }

        public PersonalizationProvider Personalization {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<PersonalizationProvider>(ProviderType.Personalization);
            }
        }

        public SocialProvider Social {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<SocialProvider>(ProviderType.Social);
            }
        }

        public StorageProvider Storage {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<StorageProvider>(ProviderType.Storage);
            }
        }

        public StoreProvider Store {
            get {
                if (!this.IsBooted) throw new Exception("[GameServices::GetProvider()] -> You should boot first!");
                return ProviderLocator<ProviderType>.Instance.GetProvider<StoreProvider>(ProviderType.Store);
            }
        }

    }
}
