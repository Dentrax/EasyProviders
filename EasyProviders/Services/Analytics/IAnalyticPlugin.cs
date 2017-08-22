using System.Collections.Generic;

namespace EasyProviders.Services.Analytics {
    public interface IAnalyticPlugin : IServicePlugin {
        void TrackRevenue(int amount);

        void TrackEvent(string eventName, Dictionary<string, string> eventData = null);
    }
}

