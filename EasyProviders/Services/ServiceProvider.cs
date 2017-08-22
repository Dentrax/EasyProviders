#region License
// ====================================================
// EasyProviders Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

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
