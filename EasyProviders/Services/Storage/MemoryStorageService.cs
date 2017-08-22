using System.Collections.Generic;
using EasyProviders.Services.Storage.State;

namespace EasyProviders.Services.Storage {
    public sealed class MemoryStorageService : StorageService {

        private Dictionary<string, string> m_storage = new Dictionary<string, string>();

        private bool m_dataChangedSinceLastLoad;

        public bool ReportConflictOnChangedData;

        public bool HasBeenWrittenTo;

        private string m_internalMockUser = string.Empty;

        public delegate void BeforeSaveDelegate(ref StorageErrorState? error);
        public MemoryStorageService.BeforeSaveDelegate JustBeforeSave;

        public override void Save(string key, string value, SaveSuccessDelegate saveSuccess, SaveErrorDelegate saveError) {
            string key2 = this.m_internalMockUser + key;
            if (this.ReportConflictOnChangedData && this.m_dataChangedSinceLastLoad) {
                saveError(key, StorageErrorState.ConflictError, value, "DummyRemoteValue");
            } else {
                if (this.JustBeforeSave != null) {
                    StorageErrorState? errorCode = null;
                    this.JustBeforeSave(ref errorCode);
                    if (errorCode.HasValue) {
                        saveError(key, errorCode.Value, value, "DummyRemoteValue");
                        return;
                    }
                }
                this.m_storage[key2] = value;
                saveSuccess(key);
                this.m_dataChangedSinceLastLoad = true;
                this.HasBeenWrittenTo = true;
            }
        }

        public override void Load(string key, LoadSuccessDelegate loadSuccess, LoadErrorDelegate loadError) {
            string key2 = this.m_internalMockUser + key;
            this.m_dataChangedSinceLastLoad = false;
            if (this.m_storage.ContainsKey(key2)) {
                loadSuccess(key, this.m_storage[key2]);
            } else {
                loadError(key, StorageErrorState.NoSuchKeyError);
            }
        }

        public void PretendThatWeReportNewDeviceID() {
            this.m_internalMockUser = "UnconnectedUser_";
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> current in this.m_storage) {
                if (current.Key.Contains(this.m_internalMockUser)) {
                    list.Add(current.Key);
                }
            }
            foreach (string current2 in list) {
                this.m_storage.Remove(current2);
            }
        }

        public void SwitchInternalMockUserAfterFacebookConnect() {
            this.m_internalMockUser = "FacebookConnectedUser_";
        }

    }
}
