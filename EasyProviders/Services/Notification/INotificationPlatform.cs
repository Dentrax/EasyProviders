using System;

namespace EasyProviders.Services.Notification {
    public interface INotificationPlatform : IServicePlatform {
        void ScheduleNotification(DateTime date, string title, string message, string soundName);
        void CancelAllNotifications();
        void EnableLogs(bool enable);
    }
}

