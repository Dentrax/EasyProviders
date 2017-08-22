using EasyProviders.Services.Analytics;
using System;
using System.Collections.Generic;

namespace EasyProviders.Services.Social.Flurry {
    public sealed class FlurryPlugin : IAnalyticPlugin {
        public bool WasLoaded { get; private set; }

        public bool IsReady {
            get { return false; }
        }

        public string PluginID {
            get { return "NULL"; }
        }

        static FlurryPlugin() { }

        ~FlurryPlugin() { }

        public void Load() {
            if (this.WasLoaded) return;


            this.WasLoaded = true;
        }
        public void Release() {
            if (!this.WasLoaded) return;

            GC.SuppressFinalize(this);
            this.WasLoaded = false;
        }

        public void TrackRevenue(int amount) { }

        public void TrackEvent(string eventName, Dictionary<string, string> eventData = null) { }
    }
}

