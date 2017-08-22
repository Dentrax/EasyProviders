namespace EasyProviders.Services.Storage.State {
    public enum StorageLoadState {
        OK,
        NotFound,
        PermissionError,
        Corrupted,
        VersionMismatch
    }
}
