using System;

namespace EasyProviders.Services.Analytics {
    public abstract class AnalyticsSessionEvent : AnalyticsEvent {

        [SerializeAsString("session_no")]
        protected int SessionID;

        [SerializeAsString("session_delta")]
        protected int SessionDelta;

        [SerializeAsString("event_no")]
        protected int SessionEventID;

        public static Func<int> GetSessionID;

        public static Func<int> GetSessionDelta;

        public static Func<int> GetSessionEventNumber;

        public AnalyticsSessionEvent() {
            this.SessionID = AnalyticsSessionEvent.GetSessionID();
            this.SessionDelta = AnalyticsSessionEvent.GetSessionDelta();
            this.SessionEventID = AnalyticsSessionEvent.GetSessionEventNumber();
        }
    }
}

