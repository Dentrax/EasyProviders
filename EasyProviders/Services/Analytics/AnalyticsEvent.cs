using System;

namespace EasyProviders.Services.Analytics {
    public abstract class AnalyticsEvent {

        [SerializeAsString("uid"), SerializeSizeLimit(36, false)]
        protected string UserID;

        [SerializeAsString("id"), SerializeSizeLimit(36, false)]
        protected string EventID;

        public static Func<string> GetGameVersion;

        public static Func<DateTime> GetDeviceStartupTime;

        public static Func<DateTime> GetTimeOffset;

        public static Func<string> GetUserID;

        public static Func<float> GetSamplingKey;

        public abstract string EventName { get; }

        public AnalyticsEvent() {
            this.EventID = Guid.NewGuid().ToString();
            this.UserID = AnalyticsEvent.GetUserID();
        }

        protected string GetEventTimeText() {
            DateTime time = AnalyticsEvent.GetDeviceStartupTime().AddMilliseconds((double)AnalyticsProvider.GetMsTicksSinceDeviceStartup());
            return AnalyticsEvent.GetTimeText(time);
        }

        public static string GetTimeText(DateTime time) {
            return string.Format("{0:0000}-{1:00}-{2:00}T{3:00}:{4:00}:{5:00}.{6:000}Z", new object[]
            {
                time.Year,
                time.Month,
                time.Day,
                time.Hour,
                time.Minute,
                time.Second,
                time.Millisecond
            });
        }

        public override string ToString() {
            return string.Format("{0} for user {1}", base.GetType().Name, this.UserID);
        }
    }
}

