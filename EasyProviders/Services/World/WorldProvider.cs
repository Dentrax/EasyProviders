using System;

namespace EasyProviders.Services.World {
    public sealed class WorldProvider : ServiceProvider, IWorldProvider {
        public sealed new class InitializeContext : ServiceProvider.InitializeContext {

            public InitializeContext() : base() {

            }
        }

        public WorldProvider() { }

        ~WorldProvider() { }


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
            throw new NotImplementedException();
        }

        public override void Stop() {
            throw new NotImplementedException();
        }

        public string GetDefaultCountryCodeFromDevice() {

            return "EN";
        }
    }
}



