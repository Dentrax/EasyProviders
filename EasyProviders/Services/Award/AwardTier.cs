namespace EasyProviders.Services.Award {
    public sealed class AwardTier {
        public AwardTierType Type { get; set; }
        public int Reward { get; set; }
        public AwardGoal[] Goals { get; set; }
    }
}

