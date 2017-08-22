using System;

namespace EasyProviders.Services.Notification {
    public sealed class NotificationAndroid : INotificationPlatform {

        public void ScheduleNotification(DateTime date, string title, string message, string soundPath) {
        }

        public void CancelAllNotifications() {
        }

        public void EnableLogs(bool enable) {
        }
    }
}

