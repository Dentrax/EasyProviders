using System;

namespace EasyProviders.Services.Localization {
    public sealed class LocalizationProvider : ServiceProvider, ILocalizationProvider {

        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {
            }
        }

        public LocalizationProvider() {
        }

        ~LocalizationProvider() { }

        public override void Initialize(ServiceProvider.InitializeContext context) {
            if (!this.WasInitialized) {


                this.WasInitialized = true;
            }
        }

        public override void Terminate() {
            if (this.WasInitialized) {

                GC.SuppressFinalize(this);
                this.WasInitialized = false;
            }
        }

        public override void Start() {
        }

        public override void Stop() {

        }

    }
}
