using System;
using System.Collections.Generic;

namespace EasyProviders.Services {
    public sealed class ProviderLocator<ProviderType> {

        public static readonly ProviderLocator<ProviderType> Instance = new ProviderLocator<ProviderType>();

        private readonly Dictionary<ProviderType, IServiceProvider> m_providers;

        public bool IsBooted { get; private set; }

        private ProviderLocator() {
            this.IsBooted = false;
            this.m_providers = new Dictionary<ProviderType, IServiceProvider>();
        }

        public static bool Boot(Dictionary<ProviderType, IServiceProvider> providers, Action onDone = null) {
            if (ProviderLocator<ProviderType>.Instance.IsBooted) {
                throw new ProviderException("[FTProviderLocator::Boot()] -> Providers already booted!");
            }

            ProviderLocator<ProviderType>.Instance.m_providers.Clear();

            try {
                ProviderLocator<ProviderType>.Instance.SetupProviders(providers);
                ProviderLocator<ProviderType>.Instance.StartProviders();
                ProviderLocator<ProviderType>.Instance.IsBooted = true;

                if (onDone != null) onDone();

                return true;
            } catch (Exception ex){
                throw new ProviderException("[FTProviderLocator::Boot()] -> An exception was received while booting providers. Exception : " + ex.ToString());
            }
        }

        public static bool Shutdown(Dictionary<ProviderType, IServiceProvider> providers, Action onDone = null) {
            if (!ProviderLocator<ProviderType>.Instance.IsBooted) {
                throw new ProviderException("[FTProviderLocator::Shutdown()] -> You should Boot Providers first!");
            }

            try {
                ProviderLocator<ProviderType>.Instance.StopProviders();
                ProviderLocator<ProviderType>.Instance.IsBooted = false;

                if (onDone != null) onDone();

                return true;
            } catch (Exception ex) {
                throw new ProviderException("[FTProviderLocator::Shutdown()] -> An exception was received while shutting-down providers. Exception : " + ex.ToString());
            }
        }

        public T GetProvider<T>(ProviderType providerType) {
            if (this.m_providers.ContainsKey(providerType)) {
                return (T)((object)this.m_providers[providerType]);
            }
            throw new ProviderException("[FTProviderLocator::GetProvider()] -> Provider(" + providerType.ToString() + ") not ready.");
        }

        private void SetupProviders(Dictionary<ProviderType, IServiceProvider> providers) {
            foreach (KeyValuePair<ProviderType, IServiceProvider> current in providers) {
                if (ProviderLocator<ProviderType>.Instance.m_providers.ContainsKey(current.Key)) {
                    throw new ProviderException("[FTProviderLocator::SetupProviders()] -> Provider already loaded for: " + current.Key);
                }
                ProviderLocator<ProviderType>.Instance.m_providers.Add(current.Key, current.Value);
            }
        }

        private void StartProviders() {
            foreach (KeyValuePair<ProviderType, IServiceProvider> current in this.m_providers) {
                current.Value.Start();
            }
        }
   
        public void StopProviders() {
            foreach (KeyValuePair<ProviderType, IServiceProvider> current in this.m_providers) {
                current.Value.Stop();
            }
        }
    }
}
