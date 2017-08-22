namespace EasyProviders.Services {
    public abstract class ServicePlugin : IServicePlugin {
        public bool WasLoaded { get; protected set; }
        public bool IsReady { get; protected set; }
        public string PluginID { get; protected set; }

        public abstract void Load();
        public abstract void Release();
    }
}
