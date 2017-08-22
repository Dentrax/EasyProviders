using System;

namespace EasyProviders.Services.Advertising {
    public struct AdLocationInfo {
        public AdLocationType LocationType { get; set; }
        public AdType AdType { get; set; }
        public DateTime LastShownAdTimeStamp { get; set; }
        public uint TimeLimitToNextShow { get; set; }
        public bool Enabled { get; set; }
    }
}
