using System;
using System.Globalization;

namespace EasyProviders.Services.Date {
    public sealed class LocalClientDateService : DateService, IDateTime {

        public DateTime ServerNow {
            get { return DateTime.UtcNow; }
        }

        public DateTime LocalNow {
            get { return DateTime.Now ; }
        }

        public string NowAsString {
            get { return this.ServerNow.ToString("s", DateTimeFormatInfo.InvariantInfo); }
        }

        public DateTime UtcToLocal(DateTime time) {
            return time;
        }

        public DateTime LocalToUtc(DateTime time) {
            return time;
        }

        public bool IsSyncedWithServer() {
            return this.m_isSyncedWithServer;
        }

        public void SyncWithServer(Action<bool> callback) {
            this.m_isSyncedWithServer = true;
            if (callback != null) {
                callback(true);
            }
        }

    }
}
