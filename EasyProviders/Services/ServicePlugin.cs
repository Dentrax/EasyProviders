#region License
// ====================================================
// EasyProviders Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

namespace EasyProviders.Services {
    public abstract class ServicePlugin : IServicePlugin {
        public bool WasLoaded { get; protected set; }
        public bool IsReady { get; protected set; }
        public string PluginID { get; protected set; }

        public abstract void Load();
        public abstract void Release();
    }
}
