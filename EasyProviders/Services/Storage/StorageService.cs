using EasyProviders.Services.Storage.State;

namespace EasyProviders.Services.Storage {
    public abstract class StorageService {

        public delegate void SaveSuccessDelegate(string key);
        public delegate void SaveErrorDelegate(string key, StorageErrorState errorState, string localValue, string remoteValue);
        public delegate void LoadSuccessDelegate(string key, string value);
        public delegate void LoadErrorDelegate(string key, StorageErrorState errorState);

        public abstract void Save(string key, string value, StorageService.SaveSuccessDelegate saveSuccess, StorageService.SaveErrorDelegate saveError);
        public abstract void Load(string key, StorageService.LoadSuccessDelegate loadSuccess, StorageService.LoadErrorDelegate loadError);

    }
}
