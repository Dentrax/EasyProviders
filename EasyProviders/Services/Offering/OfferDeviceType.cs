using System;

namespace EasyProviders.Services.Offering {

    [Flags]
    public enum OfferDeviceType {
        iPhone = 1,
        iPad = 2,
        Android = 4,
        Amazon = 8,
        NONE
    }
}
