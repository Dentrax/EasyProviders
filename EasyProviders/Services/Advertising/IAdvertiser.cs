using EasyProviders.Services.Advertising.Advertiser;

namespace EasyProviders.Services.Advertising {
    public interface IAvertiser {
        AdvertiserType Type { get; }
        int Weight { get; }
        int Priority { get; }
    }
}
