using System;

namespace EasyProviders.Services.Date {
    public interface IDateTime {
        DateTime ServerNow { get; }
        DateTime LocalNow { get; }

        string NowAsString { get; }

        DateTime UtcToLocal(DateTime time);
        DateTime LocalToUtc(DateTime time);

        bool IsSyncedWithServer();
        void SyncWithServer(Action<bool> callback);
    }
}
