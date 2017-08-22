namespace EasyProviders.Services.Advertising {
    public struct AdUnitInfo {
        public string UnitID { get; private set; }
        public AdType AdType { get; private set; }
        public AdUnitInfo(string unitId, AdType adType) {
            this.UnitID = unitId;
            this.AdType = adType;
        }
    }
}
