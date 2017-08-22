using EasyProviders.Services.World.Region;

namespace EasyProviders.Services.World.Country {
    public struct Country {
        public string ShortName { get; private set; }
        public string Code2A { get; private set; }
        public string Code3A { get; private set; }
        public string LongName { get; private set; }
        public string Capital { get; private set; }
        public RegionType Region { get; private set; }

        public static readonly Country EMPTY = new Country("", "", "", "", "", RegionType.NONE);

        public Country(string shortName, string code2A, string code3A, string longName, string capital, RegionType region) {
            this.ShortName = shortName;
            this.Code2A = code2A;
            this.Code3A = code3A;
            this.LongName = longName;
            this.Capital = capital;
            this.Region = region;
        }
    }
}

