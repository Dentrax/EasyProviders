using System;

namespace EasyProviders.Services.Notification {
    public sealed class NotificationEditor : INotificationPlatform {

        public void ScheduleNotification(DateTime date, string title, string message, string soundName) {
        }

        public void CancelAllNotifications() { }

        public void EnableLogs(bool enable) { }

    }
}

