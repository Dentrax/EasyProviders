namespace EasyProviders.Services {
    public interface IServiceProvider : IProvider {
        void Initialize(ServiceProvider.InitializeContext context);
        void Terminate();
    }
}
