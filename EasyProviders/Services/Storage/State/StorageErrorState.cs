namespace EasyProviders.Services.Storage.State {
    public enum StorageErrorState {
        NoError,
        MalformedRequestError,
        NoSuchKeyError,
        ConflictError,
        ServiceNotAvailableError,
        NetworkingError,
        Unknown
    }
}
