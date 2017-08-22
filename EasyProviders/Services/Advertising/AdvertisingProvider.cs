using System;
using System.Collections.Generic;
using EasyProviders.Services.Advertising.Advertiser;
using EasyProviders.Services.Advertising.Advertiser.AdMob;
using EasyProviders.Services.Advertising.Advertiser.Flurry;

namespace EasyProviders.Services.Advertising {
    public sealed class AdvertisingProvider : ServiceProvider, IAdvertisingProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public AdvertisingProvider() { }

        ~AdvertisingProvider() { }


        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {

                this.WasInitialized = true;
            }
        }

        public override void Terminate() {
            if (this.WasInitialized) {

                GC.SuppressFinalize(this);
                this.WasInitialized = false;
            }
        }

        public override void Start() {
        }

        public override void Stop() {
        }

        private AdMobPlugin m_adMob;


        private FlurryPlugin m_flurry;


        private List<AdvertiserPlugin> m_currentListOfBannerPlugins;

        private AdvertiserPlugin m_currentBannerPlugin;
        private AdvertiserPlugin m_lastBannerPlugin;
        private Action m_onBannerAdStateChangedHandler;
        private Action m_onBannerPluginChangedHandler;
        private int m_bannerAdIndex = -1;

        public AdState CurrentBannerAdState { get; private set; }

        private List<AdvertiserPlugin> m_currentListOfInterstitialPlugins;

        private AdvertiserPlugin m_currentInterstitialPlugin;
        private AdvertiserPlugin m_lastInterstitialPlugin;
        private Action m_onInterstitialAdStateChangedHandler;
        private Action m_onInterstitialPluginChangedHandler;
        private int m_interstitialAdIndex = -1;

        public AdState CurrentInterstitialAdState { get; private set; }

        private List<AdvertiserPlugin> m_currentListOfVideoPlugins;

        private AdvertiserPlugin m_currentVideoPlugin;
        private AdvertiserPlugin m_lastVideoPlugin;
        private Action m_onVideoAdStateChangedHandler;
        private Action m_onVideoPluginChangedHandler;
        private int m_videoAdIndex = -1;

        public AdState CurrentVideoAdState { get; private set; }

        public bool IsAnyBannerShowing {
            get { return this.m_adMob.IsBannerShowing() || this.m_flurry.IsBannerShowing(); }
        }
        public bool IsAnyInterstitialShowing {
            get { return this.m_adMob.IsInterstitialShowing() ||this.m_flurry.IsInterstitialShowing() ; }
        }
        public bool IsAnyVideoShowing {
            get { return this.m_adMob.IsVideoShowing() || this.m_flurry.IsVideoShowing(); }
        }

        public bool IsAnyAdShowing {
            get { return this.IsAnyBannerShowing || this.IsAnyInterstitialShowing || this.IsAnyVideoShowing; }
        }

        #region BANNER_FUNCTIONS

        public AdvertiserPlugin GetCurrentBannerPlugin() {
            return this.m_currentBannerPlugin;
        }

        public AdvertiserPlugin GetLastBannerPlugin() {
            return this.m_lastBannerPlugin;
        }

        public AdvertiserType GetCurrentBannerAdAvertiserType() {
            if (this.m_currentBannerPlugin != null) {
                return this.m_currentBannerPlugin.Type;
            }
            return AdvertiserType.NONE;
        }

        public AdvertiserType GetLastBannerAdAvertiserType() {
            if (this.m_lastBannerPlugin != null) {
                return this.m_lastBannerPlugin.Type;
            }
            return AdvertiserType.NONE;
        }

        public bool HasCachedBanner() {
            return this.m_currentBannerPlugin != null && this.m_currentBannerPlugin.HasCachedBanner();
        }

        public bool IsBannerAdAvailable() {
            return this.CurrentBannerAdState == AdState.Ready;
        }

        public bool ShowBanner() {
            return false;
        }

        private void RefreshBannerPlugins() {
            this.m_bannerAdIndex = -1;

            this.m_currentListOfBannerPlugins = this.GetBannerPluginList();
            this.m_currentBannerPlugin = this.GetNextBannerPlugin();

            this.RaiseOnBannerPluginChangedHandler();
        }

        private List<AdvertiserPlugin> GetBannerPluginList() {

            return null;
        }

        private void SetCurrentBannerPlugin(AdvertiserPlugin plugin) {

        }

        private void GoToNextBannerPlugin() {
            this.m_currentBannerPlugin = this.GetNextBannerPlugin();
            this.RaiseOnBannerPluginChangedHandler();
            if (this.m_currentBannerPlugin != null && this.m_currentBannerPlugin.WasLoaded) {
                this.m_currentBannerPlugin.CacheBanner();
            } else {
                this.CurrentBannerAdState = AdState.NoAD;
                this.RaiseOnBannerAdStateChangedHandler();
            }
        }

        private AdvertiserPlugin GetNextBannerPlugin() {
            if (this.m_currentListOfBannerPlugins.Count > this.m_bannerAdIndex + 1) {
                this.m_bannerAdIndex++;
                return this.m_currentListOfBannerPlugins[this.m_bannerAdIndex];
            }
            this.m_bannerAdIndex = -1;
            return null;
        }

        public void ResetBannerAdIndex() {
            this.m_bannerAdIndex = 0;
        }

        private void RaiseOnBannerPluginChangedHandler() {
            if (this.m_onBannerPluginChangedHandler != null) this.m_onBannerPluginChangedHandler();
        }

        private void RaiseOnBannerAdStateChangedHandler() {
            if (this.m_onBannerAdStateChangedHandler != null) this.m_onBannerAdStateChangedHandler();
        }

        #endregion

        #region INTERSTITIAL_FUNCTIONS

        public AdvertiserPlugin GetCurrentInterstitialPlugin() {
            return this.m_currentInterstitialPlugin;
        }

        public AdvertiserPlugin GetLastInterstitialPlugin() {
            return this.m_lastInterstitialPlugin;
        }

        public AdvertiserType GetCurrentInterstitialAdAvertiserType() {
            if (this.m_currentInterstitialPlugin != null) {
                return this.m_currentInterstitialPlugin.Type;
            }
            return AdvertiserType.NONE;
        }

        public AdvertiserType GetLastInterstitialAdAvertiserType() {
            if (this.m_lastInterstitialPlugin != null) {
                return this.m_lastInterstitialPlugin.Type;
            }
            return AdvertiserType.NONE;
        }

        public bool HasCachedInterstial() {
            return this.m_currentInterstitialPlugin != null && this.m_currentInterstitialPlugin.HasCachedInterstitial();
        }

        public bool IsInterstitialAdAvailable() {
            return this.CurrentInterstitialAdState == AdState.Ready;
        }

        #endregion

        #region VIDEO_FUNCTIONS

        public AdvertiserPlugin GetCurrentVideoAdPlugin() {
            return this.m_currentVideoPlugin;
        }

        public AdvertiserPlugin GetLastVideoAdPlugin() {
            return this.m_lastVideoPlugin;
        }

        public AdvertiserType GetCurrentVideoAdAvertiserType() {
            if (this.m_currentVideoPlugin != null) {
                return this.m_currentVideoPlugin.Type;
            }
            return AdvertiserType.NONE;
        }

        public AdvertiserType GetLastVideoAdAvertiserType() {
            if (this.m_lastVideoPlugin != null) {
                return this.m_lastVideoPlugin.Type;
            }
            return AdvertiserType.NONE;
        }

        public bool HasCachedVideo() {
            return this.m_currentVideoPlugin != null && this.m_currentVideoPlugin.HasCachedVideo();
        }

        public bool IsVideoAdAvailable() {
            return this.CurrentVideoAdState == AdState.Ready;
        }

        #endregion

    }
}
