using System.Collections.Generic;

namespace EasyProviders.Services.Advertising {
    public sealed class AdvertisingProxy {

        public List<AdvertiserPlugin> Plugins { get; private set; }

        public AdvertisingProxy(List<AdvertiserPlugin> plugins) {
            this.Plugins = plugins;
        }
    }
}
