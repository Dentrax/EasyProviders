namespace EasyProviders.Services.Storage.State {
    public enum StorageSyncState {
        Successful,
        UpgradeNeeded,
        PermissionError,
        Corrupted,
        Inaccessible,
        Error
    }
}
