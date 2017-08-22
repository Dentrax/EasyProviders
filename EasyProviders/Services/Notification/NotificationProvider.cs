using System;

namespace EasyProviders.Services.Notification {
    public sealed class NotificationProvider : ServiceProvider, INotificationProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {
            
            public InitializeContext() : base() {
               
            }
        }

        public INotificationPlatform NotificationPlatform { get; private set; }

        public NotificationProvider() {

        }

        ~NotificationProvider() { }


        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {
                this.RegisterNotificationPlatform();
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
   
        private void RegisterNotificationPlatform() {
            //TODO: Simple Switch Case
            NotificationPlatform = new NotificationEditor();
            //NotificationPlatform = new NotificationMacPlayer();
            //NotificationPlatform = new NotificationWindowsPlayer();
            //NotificationPlatform = new NotificationEditor();
            //NotificationPlatform = new NotificationIOS();
            //NotificationPlatform = new NotificationAndroid();
            //NotificationPlatform = new NotificationWP8();
            //NotificationPlatform = new NotificationEditor();
        }
        public void SendNotification(string text) {
            throw new NotImplementedException();
        }


        public DateTime GetNextNotificationTimeForVideos() {
            return DateTime.Today.AddHours(19.0);
        }

        public void ScheduleNotification(DateTime date, string title, string message, string soundName) {
            if (this.WasInitialized && NotificationPlatform != null) {
                this.NotificationPlatform.ScheduleNotification(date, title, message, soundName);
            }
        }

        public void CancelAllNotifications() {
            if (this.WasInitialized && NotificationPlatform != null) {
                this.NotificationPlatform.CancelAllNotifications();
            }
        }

        public void EnableLogs(bool enable) {
            if (this.WasInitialized && NotificationPlatform != null) {
                this.NotificationPlatform.EnableLogs(enable);
            }
        }

    }
}

