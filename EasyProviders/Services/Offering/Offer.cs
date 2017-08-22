using System;

namespace EasyProviders.Services.Offering {
    public struct Offer {
  
        public string ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public OfferDeviceType DeviceType { get; set; }
        public OfferType Type { get; set; }
        public OfferDisplayType DisplayType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LevelStartIndex { get; set; }
        public int LevelEndIndex { get; set; }
        public int LevelInterval { get; set; }
        public int Duration { get; set; }
        public bool IsMustBeAbleToGrantFeatures { get; set; }
        public bool IsMoneySpenderOnly { get; set; }
        public bool IsOneTimeOffer { get; set; }
        public bool IsLimitedTimeOffer { get; set; }
        public bool IsAllowedSameMoreThanOne { get; set; }
        public bool IsHidden { get; set; }
        public bool ForceShownTrigger { get; set; }

    }
}

