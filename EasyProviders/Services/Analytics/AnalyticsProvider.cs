using System;
using System.Collections.Generic;

namespace EasyProviders.Services.Analytics {
    public sealed class AnalyticsProvider : ServiceProvider, IAnalyticsProvider {
        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }


        private bool m_validUser;

        private bool m_isFlushing;

        private bool m_flushDelayed;

        private bool m_retryOnTimeoutOr5xxError;

        private DateTime m_deviceStartupTime;

        private string m_userID = string.Empty;

        private static long m_tickOffset = 0L;

        private static long m_lastTick = -1L;

        public AnalyticsProvider() { }

        ~AnalyticsProvider() { }


        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {

                this.WasInitialized = true;
            }
        }

        public override void Terminate() {
            if (this.WasInitialized) {

                GC.SuppressFinalize(this);
                this.WasInitialized = false;
            }
        }

        public override void Start() {
        }

        public override void Stop() {
        }

        public static long GetMsTicksSinceDeviceStartup() {
            long num = (long)((ulong)Environment.TickCount);
            bool flag = num < AnalyticsProvider.m_lastTick;
            if (flag) {
                AnalyticsProvider.m_tickOffset += -1L;
            }
            AnalyticsProvider.m_lastTick = num;
            return AnalyticsProvider.m_tickOffset + num;
        }

        public void StartSession(string apiKey, string userId) {
        }

        public void EndSession() {
        }

        public void LogEvent(string eventName) {
        }

        public void LogEventWithAParameter(string eventName, string argKey, string argValue) {
        }

        public void LogEventWithSeveralParameters(string eventName, Dictionary<string, string> parameters) {
        }

        public void LogEventWithSeveralParameters(string eventName, string argKeys, string argValues) {
        }
    }
}
