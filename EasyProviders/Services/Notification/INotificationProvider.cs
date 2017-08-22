namespace EasyProviders.Services.Notification {
    public interface INotificationProvider : IServiceProvider {
        void SendNotification(string text);
    }
}
