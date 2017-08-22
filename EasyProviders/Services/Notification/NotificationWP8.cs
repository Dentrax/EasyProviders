using System;

namespace EasyProviders.Services.Notification {
    public sealed class NotificationWP8 : INotificationPlatform {

        public void ScheduleNotification(DateTime date, string title, string message, string soundName) {
            return;
        }

        public void CancelAllNotifications() {
            return;
        }

        public void EnableLogs(bool enable) {
            return;
        }
    }
}

