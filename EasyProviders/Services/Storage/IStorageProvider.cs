namespace EasyProviders.Services.Storage {
    public interface IStorageProvider : IServiceProvider {
        //TODO: Bitmedi.
        bool CanSave { get; set; }
    }
}

