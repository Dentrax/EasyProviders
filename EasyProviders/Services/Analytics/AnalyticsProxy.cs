using System.Collections.Generic;

namespace EasyProviders.Services.Analytics {
    public sealed class AnalyticsProxy {

        public List<IAnalyticPlugin> Plugins { get; private set; }

        public AnalyticsProxy(List<IAnalyticPlugin> plugins) {
            this.Plugins = plugins;
        }
    }
}
