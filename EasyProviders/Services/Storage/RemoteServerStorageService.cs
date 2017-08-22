using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyProviders.Services.Storage {
    public sealed class RemoteServerStorageService : StorageService {
        public override void Save(string key, string value, SaveSuccessDelegate saveSuccess, SaveErrorDelegate saveError) {
            throw new NotImplementedException();
        }
        public override void Load(string key, LoadSuccessDelegate loadSuccess, LoadErrorDelegate loadError) {
            throw new NotImplementedException();
        }
    }
}
