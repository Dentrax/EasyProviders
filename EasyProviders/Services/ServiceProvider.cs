namespace EasyProviders.Services {
    public abstract class ServiceProvider : IServiceProvider {
        public class InitializeContext : ServiceContext {
            public InitializeContext() {
            }
        }
        public bool WasInitialized { get; protected set; }

        public bool IsStarted { get; protected set; }

        public abstract void Initialize(ServiceProvider.InitializeContext context);

        public abstract void Terminate();

        public abstract void Start();

        public abstract void Stop();
    }
}
