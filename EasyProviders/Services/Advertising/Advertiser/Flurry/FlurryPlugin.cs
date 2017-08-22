using System;

namespace EasyProviders.Services.Advertising.Advertiser.Flurry {
    public sealed class FlurryPlugin : AdvertiserPlugin, IAvertiser {
        private FlurryPlugin() : base() {
            this.Type = AdvertiserType.Flurry;
        }

        public override void Load() {
            if (!this.WasLoaded) {
                this.RegisterEventHandlers();
                base.Load();
            }
        }
        public override void Release() {
            if (this.WasLoaded) {
                this.RemoveEventHandlers();
                base.Release();
            }
        }

        public void RegisterEventHandlers() {
            throw new NotImplementedException();
        }

        public void RemoveEventHandlers() {
            throw new NotImplementedException();
        }
        public override void CacheInterstitial() {
            throw new NotImplementedException();
        }

        public override void CacheBanner() {
            throw new NotImplementedException();
        }

        public override void CacheVideo() {
            throw new NotImplementedException();
        }

        public override void CreateBanner(BannerLocationType location) {
            throw new NotImplementedException();
        }

        public override void DestroyBanner() {
            throw new NotImplementedException();
        }

        public override bool HasCachedBanner() {
            throw new NotImplementedException();
        }

        public override bool HasCachedInterstitial() {
            throw new NotImplementedException();
        }

        public override bool HasCachedVideo() {
            throw new NotImplementedException();
        }

        public override bool HideBanner() {
            throw new NotImplementedException();
        }

        public override bool IsAdTypeSupported(AdType adType) {
            throw new NotImplementedException();
        }

        public override bool IsAdvertiserSupported() {
            throw new NotImplementedException();
        }

        public override bool IsBannerAvailable() {
            throw new NotImplementedException();
        }

        public override bool IsBannerShowing() {
            throw new NotImplementedException();
        }

        public override bool IsInterstitialAvailable() {
            throw new NotImplementedException();
        }

        public override bool IsInterstitialShowing() {
            throw new NotImplementedException();
        }

        public override bool IsVideoAvailable() {
            throw new NotImplementedException();
        }

        public override bool IsVideoShowing() {
            throw new NotImplementedException();
        }

        public override void RequestInterstitial() {
            throw new NotImplementedException();
        }

        public override void RequestVideo() {
            throw new NotImplementedException();
        }

        public override bool ShowBanner() {
            throw new NotImplementedException();
        }

        public override bool ShowInterstitial() {
            throw new NotImplementedException();
        }

        public override bool ShowVideo() {
            throw new NotImplementedException();
        }
    }
}