using System;
using System.Collections;
using System.Collections.Generic;
using EasyProviders.Services.Advertising.Advertiser;

namespace EasyProviders.Services.Advertising {
    public abstract class AdvertiserPlugin : ServicePlugin {
        public AdvertiserType Type { get; protected set; }
        public int Priority { get; protected set; }
        public int Weight { get; protected set; }

        public AdState State { get; protected set; }

        public string BannerID { get; private set; }
        public string InterstitialID { get; private set; }
        public string VideoID { get; private set; }

        public float AmountOfTimePaused { get; private set; }
        public float AppMinimizedTime { get; private set; }
        public float AppResumedTime { get; private set; }

        public bool IsBannerCheckingAvailability { get; protected set; }
        public bool IsInterstitialCheckingAvailability { get; protected set; }
        public bool IsVideoCheckingAvailability { get; protected set; }

        public bool IsVideoWatched { get; protected set; }


        protected bool m_adEnabled;

        protected bool m_bannerEnabled;
        protected bool m_interstitialEnabled;
        protected bool m_videoEnabled;

        protected bool m_bannerReady;
        protected bool m_interstitialReady;
        protected bool m_videoReady;

        protected float m_bannerHeightPx;
        protected float m_bannerHeight;

        protected int m_bannerShowCount;
        protected int m_interstitialShowCount;
        protected int m_videoShowCount;

        protected float m_bannerLastShowTime;
        protected float m_interstitialLastShowTime;
        protected float m_videoLastShowTime;

        protected int m_viewsPerUserForTime;
        protected int m_dontShowMoreThan;

        protected int m_refreshRate;

        protected bool m_canUseHTTPS;
        protected bool m_canUseLocation;

        protected bool m_canBeLandscape;
        protected bool m_canBePortrait;

        protected float m_cachingVideoStartTime = 0f;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdAvailable;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdUnavailable;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdDismiss;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdShowSuccess;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdShowFailed;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdWatched;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdSkipped;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdClicked;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdCachedSuccess;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdCacheFailed;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdCacheTimedOut;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdTakeoverBegan;

        protected Dictionary<AdType, Action<AdvertiserPlugin>> m_onAdTakeoverEnded;

        public AdvertiserPlugin() {
            this.Type = AdvertiserType.NONE;
            this.State = AdState.NoAD;
        }


        public override void Load() {
            if (!this.WasLoaded) {

                this.WasLoaded = true;
            }
        }

        public override void Release() {
            if (this.WasLoaded) {

                GC.SuppressFinalize(this);
                this.WasLoaded = false;
            }
        }


        public abstract bool IsAdTypeSupported(AdType adType);

        public abstract bool IsAdvertiserSupported();

        #region Banner

        public abstract void CreateBanner(BannerLocationType location);
        public abstract void DestroyBanner();
        public abstract void CacheBanner();
        public abstract bool ShowBanner();
        public abstract bool HideBanner();
        public abstract bool HasCachedBanner();
        public abstract bool IsBannerAvailable();
        public abstract bool IsBannerShowing();

        #endregion

        #region Interstitial

        public abstract void RequestInterstitial();
        public abstract bool ShowInterstitial();
        public abstract void CacheInterstitial();
        public abstract bool HasCachedInterstitial();
        public abstract bool IsInterstitialAvailable();
        public abstract bool IsInterstitialShowing();

        #endregion

        #region Video

        public abstract void RequestVideo();
        public abstract bool ShowVideo();
        public abstract void CacheVideo();
        public abstract bool HasCachedVideo();
        public abstract bool IsVideoAvailable();
        public abstract bool IsVideoShowing();


        #endregion

    }
}

