namespace EasyProviders.Services.Storage.State {
    public enum ConflictState {
        RecommendLocal,
        RecommendCloud,
        UseLocal,
        UseCloud,
        UserDecision,
        Equal,
        LocalSaveCorrupt,
        CloudSaveCorrupt,
        LocalCorruptUpgradeNeeded
    }
}
